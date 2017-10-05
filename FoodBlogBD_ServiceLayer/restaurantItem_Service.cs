using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class restaurantItem_Service : irestaurantItems_Service
    {
        irestaurantItems_DataAccess data;

        public restaurantItem_Service(irestaurantItems_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<restaurantItem> GetByRestaurant(int restaurantID)
        {
            return this.data.GetByRestaurant(restaurantID);
        }
        public IEnumerable<restaurantItem> GetByCategory(int categoryID)
        {
            return this.data.GetByCategory(categoryID);
        }
        public IEnumerable<restaurantItem> GetBySection(int sectionitemSection)
        {
            return this.data.GetBySection(sectionitemSection);
        }
        public IEnumerable<restaurantItem> GetByPrice(int id, int min, int max)
        {
            return this.data.GetByPrice(id,min, max);
        }
        public void Insert(restaurantItem restaurantItem)
        {
            this.data.Insert(restaurantItem);
        }
        public void Update(restaurantItem restaurantItem)
        {
            this.data.Update(restaurantItem);
        }
        public void DeleteSingle(int id)
        {
            this.data.DeleteSingle(id);
        }
        public void DeleteByRestaurant(int restaurantID)
        {
            this.data.DeleteByRestaurant(restaurantID);
        }
        public IEnumerable<restaurantItem> searchItem(string keyword)
        {
            return this.data.searchItem(keyword);
        }
    }
}
