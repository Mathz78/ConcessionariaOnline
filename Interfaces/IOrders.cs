using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Interfaces
{
    public interface IOrders
    {
        /// <summary>
        /// Create an order when a client wants to buy a car
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="carId"></param>
        /// <returns></returns>
        public OrderReponse CreateOrder(OrderRequest order);
    }
}