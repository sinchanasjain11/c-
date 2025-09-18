using System;

namespace PaymentProcessingSystem
{
    // Base class
    class Payment
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Payment(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        // Virtual method to process payment
        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing a payment of ₹{Amount} on {Date:d}");
        }
    }

    // Derived class for Credit Card Payment
    class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }

        public CreditCardPayment(double amount, DateTime date,
                                 string cardNumber, string cardHolderName)
            : base(amount, date)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("=== Credit Card Payment ===");
            Console.WriteLine($"Amount          : ₹{Amount}");
            Console.WriteLine($"Date            : {Date:d}");
            Console.WriteLine($"Card Holder     : {CardHolderName}");
            // Mask all but last 4 digits of card number
            string masked = new string('X', CardNumber.Length - 4) + CardNumber[^4..];
            Console.WriteLine($"Card Number     : {masked}");
            Console.WriteLine("Status          : Payment processed successfully.\n");
        }
    }

    // Derived class for UPI Payment
    class UpiPayment : Payment
    {
        public string UpiId { get; set; }
        public string BankName { get; set; }

        public UpiPayment(double amount, DateTime date,
                          string upiId, string bankName)
            : base(amount, date)
        {
            UpiId = upiId;
            BankName = bankName;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("=== UPI Payment ===");
            Console.WriteLine($"Amount          : ₹{Amount}");
            Console.WriteLine($"Date            : {Date:d}");
            Console.WriteLine($"UPI ID          : {UpiId}");
            Console.WriteLine($"Bank Name       : {BankName}");
            Console.WriteLine("Status          : Payment processed successfully.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Sample Credit Card payment
            CreditCardPayment cardPay = new CreditCardPayment(
                2500.75,
                DateTime.Now,
                "1234567812345678",
                "Alice Johnson"
            );

            // Sample UPI payment
            UpiPayment upiPay = new UpiPayment(
                999.50,
                DateTime.Now,
                "alice@upi",
                "State Bank of India"
            );

            // Process both payments
            cardPay.ProcessPayment();
            upiPay.ProcessPayment();
        }
    }
}
