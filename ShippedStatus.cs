public class ShippedStatus : IOrderStatus
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Cannot process the order, it is already shipped.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Order is already shipped.");
    }

    public void CompleteOrder(Order order)
    {
        Console.WriteLine("Completing the order.");
        order.SetStatus(new DeliveredStatus());
    }
}