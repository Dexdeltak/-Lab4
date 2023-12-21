using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lb2
{
    public class PostalCompany
    {
        private static PostalCompany _instance;
        private string Name { get; set; }
        private Dictionary<string, ClientCard> СlientCards { get; set; }
        private double TotalMoney { get; set; }

        private List<string> Storage;
        private string Address { get; set; }
        private string EDRPOU { get; set; }
        private decimal[] MonthlyIncome { get; set; }
        private Dictionary<string, ClientCompany> RegisteredClients { get; set; }
        
        public delegate void MethodMessage(object sender, HandlerMessage e);
        public event MethodMessage onMessage;
        public PostalCompany()
        {
            Name = "FastPost";
            Address = "Street 45, b. 109";
            EDRPOU = "345563456";
            Storage = LoadLogs(); 
            СlientCards = LoadClientCardsFromFile("client_cards.txt") ?? new Dictionary<string, ClientCard>();
            RegisteredClients = LoadClientsFromFile("company_clients.txt") ?? new Dictionary<string, ClientCompany>();
            MonthlyIncome = UpdateTaxArray();
        }

        public static PostalCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PostalCompany();
                }
                return _instance;
            }
        }

        public void AddClientCard(ClientCard clientCard)
        {
            if (!СlientCards.ContainsKey(clientCard.Id))
            {
                СlientCards.Add(clientCard.Id, clientCard);

                WriteClientCardsToFile("client_cards.txt");

                Console.WriteLine($"Нова картка зареєстрована: {clientCard.Id}");
                clientCard.onMessage += ClientCard_onMessage;
            }
            else
            {
                Console.WriteLine($"Карта з ідентифікатором {clientCard.Id} вже існує.");
            }
        }
        private void WriteClientCardsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in СlientCards)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value.Name},{kvp.Value.Email},{kvp.Value.PhoneNumber}");
                    }
                }

                Console.WriteLine("Картки збережено у файлі.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні карток у файл: {ex.Message}");
            }
        }
        private Dictionary<string, ClientCard> LoadClientCardsFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, ClientCard>();

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        var id = parts[0];
                        var name = parts[1];
                        var email = parts[2];
                        var phoneNumber = parts[3];

                        var clientCard = new ClientCard(id, name, email, phoneNumber);
                        dictionary.Add(id, clientCard);
                    }
                }
            }

            return dictionary;
        }
        public void AddCompanyClient(ClientCompany clientCompany)
        {
            if (!RegisteredClients.Values.Any(client => client.Email == clientCompany.Email))
            {
                RegisteredClients.Add(clientCompany.Id, clientCompany);

                // Запис колекції клієнтів компанії у файл
                WriteCompanyClientsToFile("company_clients.txt");

                Console.WriteLine($"Новий клієнт компанії зареєстрований: {clientCompany.Name}");
            }
            else
            {
                Console.WriteLine($"Клієнт компанії з email: {clientCompany.Email} вже існує.");

                onMessage?.Invoke(this, new HandlerMessage($"Company client via email: {clientCompany.Email} is already asleep."));
            }
        }
        private void WriteCompanyClientsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in RegisteredClients)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value.Name},{kvp.Value.Email}");
                    }
                }

                Console.WriteLine("Клієнти компанії збережено у файлі.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні клієнтів компанії у файл: {ex.Message}");
            }
        }
        private Dictionary<string, ClientCompany> LoadClientsFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, ClientCompany>();

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        var id = parts[0];
                        var name = parts[1];
                        var email = parts[2];

                        var client = new ClientCompany(id, name, email);
                        dictionary.Add(id, client);
                    }
                }
            }

            return dictionary;
        }
        public bool RemoveClientCard(string id)
        {
            // Удаляем ClientCard из словаря
            if (СlientCards.ContainsKey(id))
            {
                СlientCards.Remove(id);
                // Перезаписываем файл с обновленным словарем
                WriteClientCardsToFile("client_cards.txt");

                return true;
            } else
            {
                return false;
            }
        }
        public void WriteLogToFile(IDelivery delivery)
        {
            var log = delivery.ToString();
            Storage.Add(log);
            File.AppendAllText("logs.txt", log + Environment.NewLine);
        }
        public List<string> LoadLogs()
        {
            List<string> logs = new List<string>();

            if (File.Exists("logs.txt"))
            {
                string[] lines = File.ReadAllLines("logs.txt");

                logs.AddRange(lines);
            }
            else
            {
                Console.WriteLine("Файл logs.txt не знайдено.");
            }

            return logs;
        }

        public decimal[] UpdateTaxArray()
        {
            decimal[] taxArray = new decimal[12];
            string filePath = "logs.txt";
            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return taxArray;
            }

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(filePath);

            // Ищем строки, которые содержат "PriceToPay: " и "OperationDate: "
            Regex priceRegex = new Regex(@"PriceToPay: (\d+)", RegexOptions.Compiled);
            Regex dateRegex = new Regex(@"OperationDate: (\d{2}.\d{2}.\d{4})", RegexOptions.Compiled);

            foreach (string line in lines)
            {
                Match priceMatch = priceRegex.Match(line);
                Match dateMatch = dateRegex.Match(line);
                if (priceMatch.Success && dateMatch.Success)
                {
                    // Извлекаем число после "PriceToPay: "
                    decimal priceToPay = decimal.Parse(priceMatch.Groups[1].Value) * 0.05M;

                    // Извлекаем дату после "OperationDate: "
                    DateTime operationDate = DateTime.ParseExact(dateMatch.Groups[1].Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                    // Получаем месяц из даты
                    int month = operationDate.Month;

                    // Обновляем соответствующий элемент в массиве налогов
                    taxArray[month - 1] += priceToPay;
                }
            }

            return taxArray;
        }
        public void EventHandlerExistsClient(object sender, HandlerMessage e)
        {
            e.MessageView();
        }

        private void ClientCard_onMessage(object sender, HandlerMessage e, IDelivery package)
        {
            WriteLogToFile(package);
        }
    }
}