namespace InterfaceSegregation.Interfaces;

public interface IPaymentProcessor
{
    void ProcessCashPayment(decimal amount);
    void ProcessPaypalPayment(decimal amount);
}