// See https://aka.ms/new-console-template for more information
public interface IOrderStatus
{
    void ProcessOrder();
    void ShipOrder();
    void CompleteOrder();
}
