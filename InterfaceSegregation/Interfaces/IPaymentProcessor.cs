namespace InterfaceSegregation.Interfaces;

public interface IPaymentProcessor
{
    void ProcessCashPayment(decimal amount);
    void ProcessPaypalPayment(decimal amount);
    void ProcessCreditCardPayment(decimal amount);
    void validateCreditCard(string cardNumber);
}