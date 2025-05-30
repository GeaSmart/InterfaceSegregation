namespace InterfaceSegregation.Interfaces;

public interface ICreditCardPayment
{
    void ProcessCreditCardPayment(decimal amount);
    void ValidateCreditCard(string cardNumber);
}