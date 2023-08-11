using HotelService.Interfaces;
using HotelService.Models;
using HotelService.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IHouseRepository _houseRepository;

        public AdminController(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        [HttpPost("house/create")]
        public async Task CreateHouse([FromForm] IFormCollection formData)
        {
            

                var house = new House()
                {
                    Id = Guid.NewGuid().ToString(),
                    Number = 2,
                    Price = 30,
                    FamilyPet = FamilyPet.Dog,
                    SizeHeight = 1,
                    SizeLength = 1,
                    Status = HouseStatus.Free,
                    Photo = "DogBestHouse.jpg"
                };

                await _houseRepository.CreateAsync(house);
            
        }



    }
}
