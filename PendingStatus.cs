public class PendingStatus : IOrderStatus
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing the order.");
        order.SetStatus(new ProcessingStatus());
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Cannot ship the order, it is not yet processed.");
    }

    public void CompleteOrder(Order order)
    {
        Console.WriteLine("Cannot complete the order, it is not yet processed.");
    }
}