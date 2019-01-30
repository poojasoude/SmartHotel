using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartHotel.Clients.Core.Models;
using SmartHotel.Clients.Core.Services.Hotel;


namespace SmartHotel360.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HotelController : Controller
    {
        FakeHotelService _fakeHotelService = new FakeHotelService();

        /// <returns>Success</returns>
        [Route("Cities")]
        public Task<IEnumerable<City>> CitiesGet(string name)
        {
            //return _fakeHotelService.CitiesGetAsync(name);
            return _fakeHotelService.GetCitiesByNameAsync(name);
        }

        ///// <returns>Success</returns>
        //[Route("ConferenceRooms/search")]
        //public Task ConferenceRoomsSearchGet(int? cityId, int? rating, int? minPrice, int? maxPrice, int? guests)
        //{
        //    return _fakeHotelService.ConferenceRoomsSearchGetAsync(cityId, rating, minPrice, maxPrice, guests);
        //}

        ///// <returns>Success</returns>
        //[Route("Featured")]
        //public Task FeaturedGet()
        //{
        //    return _fakeHotelService.FeaturedGetAsync();
        //}

        /// <returns>Success</returns>
        [Route("Hotels/search")]
        public Task<IEnumerable<Hotel>> HotelsSearchGet(int? cityId, int? rating, int? minPrice, int? maxPrice)
        {
            return _fakeHotelService.SearchAsync(cityId.Value, rating.Value, minPrice.Value, maxPrice.Value);
        }

        /// <returns>Success</returns>
        [Route("Hotels/{id}")]
        public Task<Hotel> HotelsByIdGet(int id, string user)
        {
            return _fakeHotelService.GetHotelByIdAsync(id);
        }

        /// <returns>Success</returns>
        [Route("Hotels/{hotelid}/rooms")]
        public Task<IEnumerable<Room>> HotelsByHotelidRoomsGet(int hotelId)
        {
            return _fakeHotelService.GetRoomsByHotelIdAsync(hotelId);
        }

        /// <returns>Success</returns>
        [Route("Reviews/{hotelId}")]
        public Task ReviewsByHotelIdGet(int hotelId)
        {
            return _fakeHotelService.GetReviewsAsync(hotelId);
        }

        /// <returns>Success</returns>
        [Route("Services/hotel")]
        public Task ServicesHotelGet()
        {
            return _fakeHotelService.GetRoomServicesAsync();
        }

        ///// <returns>Success</returns>
        //[Route("Services/room")]
        //public Task ServicesRoomGet()
        //{
        //    return _fakeHotelService.ServicesRoomGetAsync();
        //}


    }
}
