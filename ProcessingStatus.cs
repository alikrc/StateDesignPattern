public class ProcessingStatus : IOrderStatus
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Order is already being processed.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Shipping the order.");
        order.SetStatus(new ShippedStatus());
    }

    public void CompleteOrder(Order order)
    {
        Console.WriteLine("Cannot complete the order, it is not yet shipped.");
    }
}