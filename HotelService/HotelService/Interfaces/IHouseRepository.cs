using HotelService.Models;

namespace HotelService.Interfaces
{
    public interface IHouseRepository
    {
        Task CreateAsync(House house);
        Task<List<House>> GetAllAsync();
        Task<House> GetByIdAsync(string id);
        Task UpdateAsync(House house);
        Task DeleteAsync(House house);
    }
}
