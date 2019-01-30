﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartHotel.Clients.Core.Models;

namespace SmartHotel.Clients.Core.Services.Hotel
{
    public class FakeHotelService : IHotelService
    {
        static readonly List<City> cities = new List<City>
        {
            new City
            {
                Id = 1,
                Name = "Barcelona",
                Country = "Spain",
            },
            new City
            {
                Id = 2,
                Name = "Seville",
                Country = "Spain",
            },
            new City
            {
                Id = 3,
                Name = "Seattle",
                Country = "United States"
            },
            new City
            {
                Id = 4,
                Name = "New York",
                Country = "United States"
            },
            new City
            {
                Id = 5,
                Name = "New Orleans",
                Country = "United States"
            }
        };

        static List<Models.Hotel> hotels = new List<Models.Hotel>
        {
            new Models.Hotel
            {
                Id = 1,
                CityId = 1,
                Name = "Secret Camp Hotel",
                //Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_1.png" : "img_1",
                City = "Barcelona, Spain",
                PricePerNight = 76,
                Price = 76,
                Rating = 3,
                Latitude = 47.612081510010654,
                Longitude = -122.330555830464,
                CheckInTime = "12:00:00",
                CheckOutTime = "15:00:00",
                Services = new List<Service>
                {
                    new Service { Id = 1, Name = "Free Wi-fi" }
                },
                Rooms = new List<Room>
                {
                    new Room { RoomId = 1, Quantity = 1, RoomName = "Single Room", RoomType = 1 }
                },
                Description = "The Hotel is the right choice for visitors who are searching for a combination of charm, peace and quiet. The buffet breakfast is served in the lounge on the ground floor, and also outside on our little patio during the summer months. The hotel provides an internet point, and a Wi-Fi service."
            },
            new Models.Hotel
            {
                Id = 2,
                CityId = 2,
                Name = "Prism Hotel",
                //Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_2.png" : "img_2",
                City = "Seville, Spain",
                PricePerNight = 161,
                Price = 161,
                Rating = 3,
                Latitude = 47.612081510010654,
                Longitude = -122.330555830464,
                CheckInTime = "12:00:00",
                CheckOutTime = "15:00:00",
                Services = new List<Service>
                {
                    new Service { Id = 1, Name = "Free Wi-fi" }
                },
                Rooms = new List<Room>
                {
                    new Room { RoomId = 1, Quantity = 1, RoomName = "Single Room", RoomType = 1 }
                },
                Description = "The Hotel is the right choice for visitors who are searching for a combination of charm, peace and quiet. The buffet breakfast is served in the lounge on the ground floor, and also outside on our little patio during the summer months. The hotel provides an internet point, and a Wi-Fi service."
            },
            new Models.Hotel
            {
                Id = 3,
                CityId = 3,
                Name = "Elite Hotel",
                //Picture = Device.RuntimePlatform == Device.UWP ? "Assets/img_3.png" : "img_3",
                City = "Seattle, United States",
                PricePerNight = 202,
                Price = 202,
                Rating = 4,
                Latitude = 47.612081510010654,
                Longitude = -122.330555830464,
                CheckInTime = "12:00:00",
                CheckOutTime = "15:00:00",
                Services = new List<Service>
                {
                    new Service { Id = 1, Name = "Free Wi-fi" }
                },
                Rooms = new List<Room>
                {
                    new Room { RoomId = 1, Quantity = 1, RoomName = "Single Room", RoomType = 1 }
                },
                Description = "The Hotel is the right choice for visitors who are searching for a combination of charm, peace and quiet. The buffet breakfast is served in the lounge on the ground floor, and also outside on our little patio during the summer months. The hotel provides an internet point, and a Wi-Fi service."
            }
        };

        static List<Review> reviews = new List<Review>
        {
            new Review
            {
                HotelId = 1,
                User = "John Doe",
                Message = "Have some work to do? Grab a good Full English and sit on one of the comfortable sofas with your laptop.",
                Room = "Single room",
                Date = DateTime.Today.AddDays(-1),
                Rating = 3
            },
            new Review
            {
                HotelId = 2,
                User = "Larry Cross",
                Message = "Great concept. Modern without being too clean.",
                Room = "Double room",
                Date = DateTime.Today.AddDays(-2),
                Rating = 3
            },
            new Review
            {
                HotelId = 3,
                User = "Carolyne Breit",
                Message = "Trendy hotel with the best lounge area I've ever seen. Cozy place with comfy beds.",
                Room = "Single room",
                Date = DateTime.Today.AddDays(-3),
                Rating = 4
            }
        };

        static List<Service> hotelServices = new List<Service>
        {
            new Service
            {
                Id = 1,
                Name = "Free Wi-Fi"
            },
            new Service
            {
                Id = 2,
                Name = "Pool"
            },
            new Service
            {
                Id = 2,
                Name = "Air conditioning"
            }
        };

        static List<Service> roomServices = new List<Service>
        {
            new Service
            {
                Id = 1,
                Name = "Air conditioning"
            },
            new Service
            {
                Id = 2,
                Name = "Green"
            },
            new Service
            {
                Id = 3,
                Name = "Jacuzzi"
            }
        };

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            await Task.Delay(500);

            return cities;
        }

        public async Task<IEnumerable<City>> GetCitiesByNameAsync(string name)
        {
            await Task.Delay(500);

            return cities.Where(c => c.Name.ToLower().Contains(name.ToLower()));
        }

        public async Task<Models.Hotel> GetHotelByIdAsync(int id)
        {
            await Task.Delay(500);

            return hotels.FirstOrDefault(h => h.Id == id);
        }

        public async Task<IEnumerable<Room>> GetRoomsByHotelIdAsync(int id)
        {
            await Task.Delay(500);

            return hotels.FirstOrDefault(h => h.Id == id).Rooms.ToList();
        }

        public async Task<IEnumerable<Models.Hotel>> GetMostVisitedAsync()
        {
            await Task.Delay(500);

            return hotels;
        }

        public async Task<IEnumerable<Review>> GetReviewsAsync(int id)
        {
            await Task.Delay(500);

            return reviews.Where(r => r.HotelId == id);//.ToObservableRangeCollection();
        }

        public async Task<IEnumerable<Models.Hotel>> SearchAsync(int cityId)
        {
            await Task.Delay(500);

            return hotels
                .Where(h => h.CityId == cityId);
        }

        public async Task<IEnumerable<Models.Hotel>> SearchAsync(int cityId, int rating, int minPrice, int maxPrice)
        {
            await Task.Delay(500);

            return hotels
                .Where(h => h.CityId == cityId && h.Rating == rating && h.PricePerNight >= minPrice && h.PricePerNight < maxPrice);
                //.ToObservableRangeCollection();
        }

        public async Task<IEnumerable<Service>> GetHotelServicesAsync()
        {
            await Task.Delay(500);

            return hotelServices;
        }

        public async Task<IEnumerable<Service>> GetRoomServicesAsync()
        {
            await Task.Delay(500);

            return roomServices;
        }
    }
}