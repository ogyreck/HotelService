using HotelService.Models.Enums;

namespace HotelService.Models
{
    public class Pet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerFullName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public FamilyPet FamilyPet { get; set; }
        public string Note { get; set; }
        public House House { get; set; }
        public string HouseId { get; set; }
    }
}
