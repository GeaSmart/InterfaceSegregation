namespace InterfaceSegregation.Interfaces;

public interface IPaymentProcessor
{
    void ProcessCashPayment(decimal amount);
}