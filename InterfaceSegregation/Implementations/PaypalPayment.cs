using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Implementations;

public class PaypalPayment : IPaymentProcessor
{
    public void ProcessCashPayment(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void ProcessPaypalPayment(decimal amount)
    {
        Console.WriteLine("Pago vía paypal procesado.");
    }
}