using HotelService.Models.Enums;

namespace HotelService.Models
{
    public class House
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public FamilyPet FamilyPet { get; set; }
        public double SizeLength { get; set; }
        public double SizeHeight { get; set; }

        public HouseStatus Status { get; set; }
        


    }
}
