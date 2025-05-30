using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Implementations;

public class CashPayment : IPaymentProcessor
{
    public void ProcessCashPayment(decimal amount)
    {
        Console.WriteLine("Pago en efectivo procesado.");
    }
}