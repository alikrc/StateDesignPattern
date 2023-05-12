public class Order
{
    private IOrderStatus currentStatus;

    public Order()
    {
        currentStatus = new PendingStatus();
    }

    public void SetStatus(IOrderStatus status)
    {
        currentStatus = status;
    }

    public void ProcessOrder()
    {
        currentStatus.ProcessOrder(this);
    }

    public void ShipOrder()
    {
        currentStatus.ShipOrder(this);
    }

    public void CompleteOrder()
    {
        currentStatus.CompleteOrder(this);
    }
}