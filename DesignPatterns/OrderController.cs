namespace DesignPatterns
{
    public class OrderController
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void CompleteOrder(Order order)
        {
            // other logic omitted
            _orderRepository.Add(order);
        }
    }
}