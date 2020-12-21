using CoreWebApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWebApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id =1, Name ="Hello India", Location ="Texas",Cuisine = CuisineType.Indian},
                new Restaurant{Id =2, Name ="Swadeshi", Location ="Texas",Cuisine = CuisineType.Indian},
                new Restaurant{Id =1, Name ="Italian Pizza", Location ="Texas",Cuisine = CuisineType.Italian},
                new Restaurant{Id =1, Name ="Cabo Fish Taco", Location ="North Carolina",Cuisine = CuisineType.Mexican}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
