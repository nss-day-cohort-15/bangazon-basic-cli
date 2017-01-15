using System;
using Bangazon.Orders;

namespace Bangazon.Payments
{
  public class Payment {
    public double amount { get; set; }

    private Order _order = null;

    public Order order
    {
      get {
        return _order;
      }
    }
    public Payment(Order order)
    {
      _order = order;
      Console.WriteLine("Hey I'm a general payment");
    }

    // Overriding in action
    public virtual string process() 
    {
      return $"You paid ${this.amount} for order {this.order.orderNumber}"; 
    }

    // Overloading in action
    public void confirm(string email)
    {
      Console.WriteLine($"Sending confirmation email to {email}");
    }

    public void confirm(string email, string cc)
    {
      Console.WriteLine($"Sending confirmation email to {email} and {cc}");
    }
  }
}