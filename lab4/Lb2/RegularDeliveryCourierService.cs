using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class RegularDeliveryCourierService : IDelivery
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
        public string RecipientAdress { get; set; }
        public bool IsCompleted { get; set; }

        public RegularDeliveryCourierService(
            string id,
            DateTime operationDate, 
            double packageWeight, 
            decimal priceToPay, 
            string senderName, 
            string senderPhoneNumber, 
            bool isPaidBySender, 
            string recipientName,
            string recipientPhoneNumber,
            string recipientAdress, 
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
            RecipientAdress = recipientAdress;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"ID: {Id}, OperationDate: {OperationDate}, PackageWeight: {PackageWeight}, PriceToPay: {PriceToPay}, " +
                   $"SenderName: {SenderName}, SenderPhoneNumber: {SenderPhoneNumber}, IsPaidBySender: {IsPaidBySender}, " +
                   $"RecipientName: {RecipientName}, RecipientPhoneNumber: {RecipientPhoneNumber}, RecipientAdress: {RecipientAdress}, " +
                   $"IsCompleted: {IsCompleted}";
        }
    }
}
