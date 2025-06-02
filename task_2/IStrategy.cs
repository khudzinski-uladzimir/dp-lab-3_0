namespace lab_3;

public interface IStrategy
{
    void HandleOrder(string deliveryAddress, string cafeAddress);
}
