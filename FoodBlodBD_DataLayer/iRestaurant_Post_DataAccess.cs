using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iRestaurant_Post_DataAccess
    {
        IEnumerable<Restaurant_Post> GetByRestaurant(int restaurantID);
        void Insert(Restaurant_Post restaurantPost);
        void Upadate(Restaurant_Post restaurantPost);
        void DeleteAll(int restaurantID);
        void DeleteSingle(int id);
    }
}
