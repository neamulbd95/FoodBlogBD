using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodBlodBD_DataLayer
{
    class RestaurantItem_DataAccess : irestaurantItems_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public RestaurantItem_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<restaurantItem> GetByRestaurant(int restaurantID)
        {
            return this.context.restaurantItems.Where(x => x.restaurantID == restaurantID).ToList();
        }
        public IEnumerable<restaurantItem> GetBySection(int sectionitemSection)
        {
            return this.context.restaurantItems.Where(x => x.itemSection == sectionitemSection).ToList();
        }
        public IEnumerable<restaurantItem> GetByPrice(int min, int max)
        {
            return this.context.restaurantItems.Where(x => x.itemPrice >= min && x.itemPrice <= max).ToList();
        }
        public void Insert(restaurantItem restaurantItem)
        {
            this.context.restaurantItems.Add(restaurantItem);
            this.context.SaveChanges();
        }
        public void Update(restaurantItem restaurant_Item)
        {
            restaurantItem restItem = this.context.restaurantItems.SingleOrDefault(x => x.Id == restaurant_Item.Id);
            restItem.itemPrice = restaurant_Item.itemPrice;
            restItem.itemName = restaurant_Item.itemName;

            this.context.SaveChanges();
        }
        public void DeleteSingle(int id)
        {
            restaurantItem restItem = this.context.restaurantItems.SingleOrDefault(x => x.Id == id);
            this.context.restaurantItems.Remove(restItem);

            this.context.SaveChanges();
        }
        public void DeleteByRestaurant(int restaurantID)
        {
            List<restaurantItem> restItem = this.context.restaurantItems.Where(x => x.restaurantID == restaurantID).ToList();
            this.context.restaurantItems.RemoveRange(restItem);

            this.context.SaveChanges();
        }
    }
}
