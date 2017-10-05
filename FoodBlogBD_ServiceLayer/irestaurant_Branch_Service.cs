using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface irestaurant_Branch_Service
    {
        //IEnumerable<restaurant_Branch> GetByName(string name);
        IEnumerable<restaurant_Branch> GetByRestaurant(int restaurantID);
        IEnumerable<restaurant_Branch> GetByLocation(string area);
        restaurant_Branch GetSingle(int id);
        void Insert(restaurant_Branch restaurant_Branch);
        void Update(restaurant_Branch restaurant_Branch);
        void Delete(int restaurantID);
        void DeleteByRestaurant(int restID);
    }
}
