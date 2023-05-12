// See https://aka.ms/new-console-template for more information

public class ShippedStatus : IOrderStatus
{
    public void ProcessOrder()
    {
        Console.WriteLine("Cannot process the order, it is already shipped.");
    }

    public void ShipOrder()
    {
        Console.WriteLine("Order is already shipped.");
    }

    public void CompleteOrder()
    {
        Console.WriteLine("Completing the order.");
        // Transition to DeliveredStatus
    }
}
