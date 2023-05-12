public interface IOrderStatus
{
    void ProcessOrder(Order order);

    void ShipOrder(Order order);

    void CompleteOrder(Order order);
}