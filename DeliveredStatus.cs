public class DeliveredStatus : IOrderStatus
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Cannot process the order, it is already delivered.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Cannot ship the order, it is already delivered.");
    }

    public void CompleteOrder(Order order)
    {
        Console.WriteLine("Order is already completed.");
    }
}