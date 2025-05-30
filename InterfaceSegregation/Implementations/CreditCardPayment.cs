using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Implementations;

public class CreditCardPayment : ICreditCardPayment
{
    public void ProcessCreditCardPayment(decimal amount)
    {
        Console.WriteLine("Pago con tarjeta procesado.");
    }

    public void ValidateCreditCard(string cardNumber)
    {
        Console.WriteLine("Validación de tarjeta hecha.");
    }
}