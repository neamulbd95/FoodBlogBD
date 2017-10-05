using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class restaurant_Branch_Service : irestaurant_Branch_Service
    {
        private irestaurant_Branch_DataAccess data;

        public restaurant_Branch_Service(irestaurant_Branch_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<restaurant_Branch> GetByRestaurant(int restaurantID)
        {
            return this.data.GetByRestaurant(restaurantID);
        }
        public IEnumerable<restaurant_Branch> GetByLocation(string area)
        {
            return this.data.GetByLocation(area);
        }
        public restaurant_Branch GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }

        public void Insert(restaurant_Branch restaurant_Branch)
        {
            this.data.Insert(restaurant_Branch);
        }
        public void Update(restaurant_Branch restaurant_Branch)
        {
            this.data.Update(restaurant_Branch);
        }
        public void Delete(int restaurantID)
        {
            this.data.Delete(restaurantID);
        }
        public void DeleteByRestaurant(int restID)
        {
            this.data.DeleteByRestaurant(restID);
        }
    }
}
