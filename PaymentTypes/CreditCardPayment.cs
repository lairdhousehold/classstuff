using System;

namespace ConsoleApplication
{
    public class CreditCardPayment:Payment
    {
        public string CreditcardNumber {get;set;}
        
        public override string MakePayment()
        {
            string message = string.Empty;
            if (this.Amount>0 && this.CreditCardNumber!=null)
            {
                message =$"your payment of ${this.Amount} has been processed by PayPal";
            }
            return message;

        }

    }
} 