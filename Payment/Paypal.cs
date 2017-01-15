using System;
using Bangazon.Orders;

namespace Bangazon.Payments
{
  public class Paypal: Payment 
  {
    public string email { get; set; }
    public string password { get; set; }
    public Paypal(Order order): base(order)
    {
      Console.WriteLine("Hey I'm a Paypal account");
    }
    public override string process() 
    {
      return $"You will be redirected to Paypal.com with the credentials {this.email}/{this.password}\n{base.process()}";  
    }
  }
}