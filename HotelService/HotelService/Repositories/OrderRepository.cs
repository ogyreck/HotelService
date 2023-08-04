using HotelService.Data;
using HotelService.Interfaces;
using HotelService.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Order>> GetAsync(int id)
        {

            return await _context.Orders
                .OrderByDescending(o => o.RegistraionTime)
                .ToListAsync(); 
        }

        public async Task UpdateAsync(Order order)
        {
              _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public  async Task DeleteAsync(Order order)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        
    }
}
