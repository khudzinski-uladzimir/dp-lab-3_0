namespace lab_3;

public class StrategyDelivery : IStrategy
{
    public void HandleOrder(string deliveryAddress, string cafeAddress)
    {
        Console.WriteLine(
            $"Order will be prepared at {cafeAddress} and delivered to {deliveryAddress}."
        );
    }
}