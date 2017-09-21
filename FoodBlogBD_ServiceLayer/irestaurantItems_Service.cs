using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface irestaurantItems_Service
    {
        IEnumerable<restaurantItem> GetByRestaurant(int restaurantID);
        IEnumerable<restaurantItem> GetBySection(int sectionitemSection);
        IEnumerable<restaurantItem> GetByPrice(int min, int max);
        void Insert(restaurantItem restaurantItem);
        void Update(restaurantItem restaurantItem);
        void DeleteSingle(int id);
        void DeleteByRestaurant(int restaurantID);
    }
}
