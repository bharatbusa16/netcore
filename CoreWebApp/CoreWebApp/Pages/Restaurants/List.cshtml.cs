using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApp.Core;
using CoreWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CoreWebApp.Pages.Resataurants
{
    public class ListModel : PageModel //pagemodel is the one performing data access
    {
        private readonly IConfiguration myconfig;
        private readonly IRestaurantData restaurantData;
        public string testconfig;
        public IEnumerable<Restaurant> restaurants;
        public ListModel(IConfiguration myconfig, IRestaurantData restaurantData)
        {
            this.myconfig = myconfig;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            testconfig = myconfig["MyConfig"];
            restaurants = restaurantData.GetAll();
        }
    }
}
