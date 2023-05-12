// See https://aka.ms/new-console-template for more information


public class DeliveredStatus : IOrderStatus
{
    public void ProcessOrder()
    {
        Console.WriteLine("Cannot process the order, it is already delivered.");
    }

    public void ShipOrder()
    {
        Console.WriteLine("Cannot ship the order, it is already delivered.");
    }

    public void CompleteOrder()
    {
        Console.WriteLine("Order is already completed.");
    }
}
