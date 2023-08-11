using HotelService.Interfaces;
using HotelService.Models;
using HotelService.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelService.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private IHouseRepository _houseRepository;

        public HouseController(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        [HttpGet]
        public async Task<List<House>> Index()
        {
           return await _houseRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<House> GetHouse(string id)
        {
            return await _houseRepository.GetByIdAsync
        }


        //[HttpPost]
        //public async Task Post()
        //{

        //    var house = new House()
        //    {
        //        Id = Guid.NewGuid().ToString(),
        //        Number = 1,
        //        Price = 10,
        //        FamilyPet = FamilyPet.Cat,
        //        SizeHeight = 1,
        //        SizeLength = 1,
        //        Status = HouseStatus.Free,
        //        Photo = "CatBestHouse.jpg"
        //    };
              
        //     await _houseRepository.CreateAsync(house);
        //}

    }
}
