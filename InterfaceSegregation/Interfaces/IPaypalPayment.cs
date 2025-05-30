namespace InterfaceSegregation.Interfaces;

public interface IPaypalPayment
{
    void ProcessPaypalPayment(decimal amount);
}