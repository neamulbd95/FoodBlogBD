using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_user_Review_Service : iRestaurant_user_Review_Service
    {
        private iRestaurant_user_Review_DataAccess data;

        public Restaurant_user_Review_Service(iRestaurant_user_Review_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_user_Review> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public IEnumerable<Restaurant_user_Review> GetByRestaurant(int restId)
        {
            return this.data.GetByRestaurant(restId);
        }
        public IEnumerable<Restaurant_user_Review> GetByUser(int userId)
        {
            return this.data.GetByUser(userId);
        }
        public Restaurant_user_Review GetSingle(int Id)
        {
            return this.data.GetSingle(Id);
        }
        public void Insert(Restaurant_user_Review RestaurantUserReview)
        {
            this.data.Insert(RestaurantUserReview);
        }
        public void Update(Restaurant_user_Review RestaurantUserReview)
        {
            this.data.Update(RestaurantUserReview);
        }
        public void Delete(int Id)
        {
            this.data.Delete(Id);
        }
        public void DeleteByUser(int userID)
        {
            this.data.DeleteByUser(userID);
        }
        public void DeleteByRestaurant(int restID)
        {
            this.data.DeleteByRestaurant(restID);
        }
    }
}
