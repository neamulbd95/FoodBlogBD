using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface irestaurant_Branch_DataAccess
    {
        //IEnumerable<restaurant_Branch> GetByName(string name);
        IEnumerable<restaurant_Branch> GetByRestaurant(int restaurantID);
        IEnumerable<restaurant_Branch> GetByLocation(string area);
        void Insert(restaurant_Branch restaurant_Branch);
        void Update(restaurant_Branch restaurant_Branch);
        void Delete(int restaurantID);
        void DeleteByRestaurant(int restID);
    }
}
