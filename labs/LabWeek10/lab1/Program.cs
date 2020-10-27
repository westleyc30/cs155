using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Payment
    {
        private double amount;

        public Payment()
        {

        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }

        public void PaymentDetails()
        {
            Console.WriteLine("A payment");
        }
    }
    class CashPayment:Payment
    {
        public void PaymentDetails()
        {
            Console.WriteLine("A cash Payment");
        }
    }

    class CreditCardPayment:Payment
    {
        private String name;
        private int cardNumber;
        public void PaymentDetails()
        {
            Console.WriteLine("A card Payment");
        }
    }
}
