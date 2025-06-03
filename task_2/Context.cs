namespace lab_3;

public class Context
{
    private IStrategy? _strategy;
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void HandleOrder(string deliveryAddress, string cafeAddress)
    {
        _strategy.HandleOrder(deliveryAddress, cafeAddress);
    }
}
