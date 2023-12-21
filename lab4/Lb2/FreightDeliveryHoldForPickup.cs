using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class FreightDeliveryHoldForPickup : IDelivery
    {
        public string Id { get; set; }
        public DateTime OperationDate { get; set; }
        public double PackageWeight { get; set; }
        public decimal PriceToPay { get; set; }
        public string SenderName { get; set; }
        public string SenderPhoneNumber { get; set; }
        public bool IsPaidBySender { get; set; }
        public string RecipientName { get; set; }
        public string RecipientBranchNumber { get; set; }
        public bool SpecialBaking { get; set; }
        public bool IsCompleted { get; set; }

        public FreightDeliveryHoldForPickup(
            string id,
            DateTime operationDate, 
            double packageWeight,
            decimal priceToPay,
            string senderName, 
            string senderPhoneNumber, 
            bool isPaidBySender,
            string recipientName,
            string recipientBranchNumber,
            bool specialBaking,
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
            RecipientBranchNumber = recipientBranchNumber;
            SpecialBaking = specialBaking;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"ID: {Id}, OperationDate: {OperationDate}, PackageWeight: {PackageWeight}, PriceToPay: {PriceToPay}, " +
                   $"SenderName: {SenderName}, SenderPhoneNumber: {SenderPhoneNumber}, IsPaidBySender: {IsPaidBySender}, " +
                   $"RecipientName: {RecipientName}, RecipientBranchNumber: {RecipientBranchNumber}, " +
                   $"SpecialBaking: {SpecialBaking}, IsCompleted: {IsCompleted}";
        }

    }
}
