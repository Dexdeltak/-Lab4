using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    public class ClientCard
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        private BindingList<IDelivery> OperationHistory { get; set; }
        private BindingList<IDelivery> UnfinishedOperations { get; set; }

        public delegate void MethodMessage(object sender, HandlerMessage e, IDelivery package);
        public event MethodMessage onMessage;
        public ClientCard(string id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public BindingList<IDelivery> GetOperationHistory()
        {
            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<IDelivery>();
            }

            return OperationHistory;
        }

        public BindingList<IDelivery> GetUnfinishedOperations()
        {
            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<IDelivery>();
            }

            return UnfinishedOperations;
        }

        public decimal SendPackage(IDelivery package)
        {
            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<IDelivery>();
            }
            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<IDelivery>();
            }

            OperationHistory.Add(package);
            onMessage?.Invoke(this, new HandlerMessage($"Successful operation"), package);

            if (package.IsCompleted == false)
            {
                UnfinishedOperations.Add(package);
            }

            if (package.IsPaidBySender)
            {
                return (decimal)package.PackageWeight * 0.05M + package.PriceToPay;
            } else
            {
                return (decimal)package.PackageWeight * 0.05M;
            }
        }

        public decimal ReceivePackage(IDelivery package)
        {
            decimal price = 20;

            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<IDelivery>();
            }

            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<IDelivery>();
            }

            package.IsCompleted = true;

            OperationHistory.Add(package);
            UnfinishedOperations.Remove(package);
            onMessage?.Invoke(this, new HandlerMessage($"Successful operation"), package);

            if (!package.IsPaidBySender)
            {
                return price += package.PriceToPay;
            }
            else
            {
                return price * 0.05M;
            }
        }
        public void EventHandlerSuccess(object sender, HandlerMessage e, IDelivery package)
        {
            e.MessageView();
            
        }
    }
}
