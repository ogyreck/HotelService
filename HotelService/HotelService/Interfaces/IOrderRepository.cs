using HotelService.Models;

namespace HotelService.Interfaces
{
    public interface IOrderRepository
    {
        Task CreateAsync(Order order);
        Task<List<Order>> GetAsync(int id);
        Task UpdateAsync(Order order);
        Task DeleteAsync(Order order);
    }
}
