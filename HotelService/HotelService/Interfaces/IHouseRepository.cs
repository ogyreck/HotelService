using HotelService.Models;

namespace HotelService.Interfaces
{
    public interface IHouseRepository
    {
        Task CreateAsync(House house);
        Task<List<House>> GetAsync(int id);
        Task UpdateAsync(House house);
        Task DeleteAsync(House house);
    }
}
