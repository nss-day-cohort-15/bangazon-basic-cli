using System;
using Bangazon.Orders;

namespace Bangazon.Payments
{
  public class CreditCard: Payment 
  {

    public string bankName { get; set; }
    public string accountNumber { get; set; }

    public CreditCard(Order monkeyButt): base(monkeyButt)
    {
      Console.WriteLine("Hey I'm a credit card");
    }
    public override string process()
    {
      string parentFunctionality = base.process();
      return $"You are using a {this.bankName} card, with the account number {this.accountNumber}\n{parentFunctionality}";
      
    }
  }
}