using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iRestaurant_user_Review_DataAccess
    {
        IEnumerable<Restaurant_user_Review> GetAllValues();
        IEnumerable<Restaurant_user_Review> GetByRestaurant(int restId);
        IEnumerable<Restaurant_user_Review> GetByUser(int userId);
        Restaurant_user_Review GetSingle(int Id);
        void Insert(Restaurant_user_Review RestaurantUserReview);
        void Update(Restaurant_user_Review RestaurantUserReview);
        void Delete(int Id);
        void DeleteByUser(int userID);
        void DeleteByRestaurant(int restID);
    }
}
