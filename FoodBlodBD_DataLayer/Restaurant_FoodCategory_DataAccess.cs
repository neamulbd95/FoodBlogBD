using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_FoodCategory_DataAccess : iRestaurant_FoodCategory_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_FoodCategory_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_FoodCategory> GetByRestaurant(int restaurantID)
        {
            return this.context.Restaurant_FoodCategory.Where(x => x.restaurantID == restaurantID).ToList();
        }
        public IEnumerable<Restaurant_FoodCategory> GetByCategory(int categoryID)
        {
            return this.context.Restaurant_FoodCategory.Where(x => x.categoryID == categoryID).ToList();
        }
        public void Insert(Restaurant_FoodCategory Restaurant_FoodCategory)
        {
            this.context.Restaurant_FoodCategory.Add(Restaurant_FoodCategory);
            this.context.SaveChanges();
        }
        //public void Update(Restaurant_FoodCategory RestaurantFoodCategory)
        //{
        //    Restaurant_FoodCategory foodCat = this.context.Restaurant_FoodCategory.SingleOrDefault(x=> x.Id == RestaurantFoodCategory.Id);
        //    foodCat.
        //}
        public void DeleteByRestaurant(int restaurantID)
        {
            Restaurant_FoodCategory foodCat = this.context.Restaurant_FoodCategory.SingleOrDefault(x => x.Id == restaurantID);
            this.context.Restaurant_FoodCategory.Remove(foodCat);

            this.context.SaveChanges();
        }
    }
}
