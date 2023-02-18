namespace CoffeeShop.Models.Interfaces
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
    }
}
