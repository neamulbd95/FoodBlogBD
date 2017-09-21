using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_Post_Service : iRestaurant_Post_Service
    {
        private iRestaurant_Post_DataAccess data;

        public Restaurant_Post_Service(iRestaurant_Post_DataAccess data) 
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_Post> GetByRestaurant(int restaurantID)
        {
            return this.data.GetByRestaurant(restaurantID);
        }
        public void Insert(Restaurant_Post restaurantPost)
        {
            this.data.Insert(restaurantPost);
        }
        public void Upadate(Restaurant_Post restaurantPost)
        {
            this.data.Upadate(restaurantPost);
        }
        public void DeleteAll(int restaurantID)
        {
            this.data.DeleteAll(restaurantID);
        }
        public void DeleteSingle(int id)
        {
            this.data.DeleteSingle(id);
        }
    }
}
