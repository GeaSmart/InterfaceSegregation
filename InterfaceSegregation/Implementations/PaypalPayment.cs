using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Implementations;

public class PaypalPayment : IPaypalPayment
{
    public void ProcessPaypalPayment(decimal amount)
    {
        Console.WriteLine("Pago vía paypal procesado.");
    }
}