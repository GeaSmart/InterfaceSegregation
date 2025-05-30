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

    public void ProcessCreditCardPayment(decimal amount)
    {
        throw new NotImplementedException();
    }

    public void validateCreditCard(string cardNumber)
    {
        throw new NotImplementedException();
    }
}