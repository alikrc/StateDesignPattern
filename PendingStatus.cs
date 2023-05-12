// See https://aka.ms/new-console-template for more information
public class PendingStatus : IOrderStatus
{
    public void ProcessOrder()
    {
        Console.WriteLine("Processing the order.");
        // Transition to ProcessingStatus
    }

    public void ShipOrder()
    {
        Console.WriteLine("Cannot ship the order, it is not yet processed.");
    }

    public void CompleteOrder()
    {
        Console.WriteLine("Cannot complete the order, it is not yet processed.");
    }
}
