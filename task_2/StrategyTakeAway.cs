namespace lab_3;

public class StrategyTakeAway : IStrategy
{
    public void HandleOrder(string deliveryAddress, string cafeAddress)
    {
        Console.WriteLine(
            $"Order will be prepared at {cafeAddress} and ready for pickup at {deliveryAddress}."
        );
    }
}
