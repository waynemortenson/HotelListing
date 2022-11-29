namespace HotelListing.API.Models.Hotel
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        public int CountryId { get; set; }
    }
}
