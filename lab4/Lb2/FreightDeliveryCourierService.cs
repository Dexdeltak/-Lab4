using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class FreightDeliveryCourierService : IDelivery
    {
        public string Id { get; set; }
        public DateTime OperationDate { get; set; }
        public double PackageWeight { get; set; }
        public decimal PriceToPay { get; set; }
        public string SenderName { get; set; }
        public string SenderPhoneNumber { get; set; }
        public bool IsPaidBySender { get; set; }
        public string RecipientName { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public string RecipientAddress { get; set; }
        public bool SpecialBaking { get; set; }
        public int NumberOfLoaders { get; set; }
        public bool IsCompleted { get; set; }

        public FreightDeliveryCourierService(
            string id,
            DateTime operationDate,
            double packageWeight, 
            decimal priceToPay, 
            string senderName, 
            string senderPhoneNumber,
            bool isPaidBySender, 
            string recipientName,
            string recipientPhoneNumber,
            string recipientAddress, 
            bool specialBaking, 
            int numberOfLoaders,
            bool isCompleted
            )
        {
            Id = id;
            OperationDate = operationDate;
            PackageWeight = packageWeight;
            PriceToPay = priceToPay;
            SenderName = senderName;
            SenderPhoneNumber = senderPhoneNumber;
            IsPaidBySender = isPaidBySender;
            RecipientName = recipientName;
            RecipientPhoneNumber = recipientPhoneNumber;
            RecipientAddress = recipientAddress;
            SpecialBaking = specialBaking;
            NumberOfLoaders = numberOfLoaders;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"ID: {Id}, OperationDate: {OperationDate}, PackageWeight: {PackageWeight}, PriceToPay: {PriceToPay}, " +
                   $"SenderName: {SenderName}, SenderPhoneNumber: {SenderPhoneNumber}, IsPaidBySender: {IsPaidBySender}, " +
                   $"RecipientName: {RecipientName}, RecipientPhoneNumber: {RecipientPhoneNumber}, RecipientAddress: {RecipientAddress}, " +
                   $"SpecialBaking: {SpecialBaking}, NumberOfLoaders: {NumberOfLoaders}, IsCompleted: {IsCompleted}";
        }
    }
}
