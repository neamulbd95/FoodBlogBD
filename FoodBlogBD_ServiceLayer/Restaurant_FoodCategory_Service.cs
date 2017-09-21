using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_FoodCategory_Service : iRestaurant_FoodCategory_Service
    {
        private iRestaurant_FoodCategory_DataAccess data;

        public Restaurant_FoodCategory_Service(iRestaurant_FoodCategory_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_FoodCategory> GetByRestaurant(int restaurantID)
        {
            return this.data.GetByRestaurant(restaurantID);
        }
        public IEnumerable<Restaurant_FoodCategory> GetByCategory(int categoryID)
        {
            return this.data.GetByCategory(categoryID);
        }
        public void Insert(Restaurant_FoodCategory Restaurant_FoodCategory)
        {
            this.data.Insert(Restaurant_FoodCategory);
        }
        public void DeleteByRestaurant(int restaurantID)
        {
            this.data.DeleteByRestaurant(restaurantID);
        }
    }
}
