using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Implementations;

public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessCashPayment(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void ProcessPaypalPayment(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void ProcessCreditCardPayment(decimal amount)
    {
        Console.WriteLine("Pago con tarjeta procesado.");
    }

    public void validateCreditCard(string cardNumber)
    {
        Console.WriteLine("Validación de tarjeta hecha.");
    }
}