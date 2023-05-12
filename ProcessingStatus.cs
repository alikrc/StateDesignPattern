// See https://aka.ms/new-console-template for more information
public class ProcessingStatus : IOrderStatus
{
    public void ProcessOrder()
    {
        Console.WriteLine("Order is already being processed.");
    }

    public void ShipOrder()
    {
        Console.WriteLine("Shipping the order.");
        // Transition to ShippedStatus
    }

    public void CompleteOrder()
    {
        Console.WriteLine("Cannot complete the order, it is not yet shipped.");
    }
}
