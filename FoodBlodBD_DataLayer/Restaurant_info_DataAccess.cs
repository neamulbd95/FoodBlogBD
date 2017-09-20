using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_info_DataAccess : iRestaurant_info_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_info_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_info> GetAllValues()
        {
            return this.context.Restaurant_info.ToList();
        }
        //public IEnumerable<Restaurant_info> GetByArea(string areaName)
        //{
        //    return this.context.Restaurant_info.Where(x => x.restaurantArea == areaName);
        //}
        public Restaurant_info GetSingle(int id)
        {
            return this.context.Restaurant_info.SingleOrDefault(x => x.Id == id);
        }
        public void Insert(Restaurant_info Restaurant_info)
        {
            this.context.Restaurant_info.Add(Restaurant_info);
            this.context.SaveChanges();
        }
        public void Update(Restaurant_info RestaurantInfo)
        {
            Restaurant_info restInfo = this.context.Restaurant_info.SingleOrDefault(x => x.Id == RestaurantInfo.Id);
            restInfo.restaurantName = RestaurantInfo.restaurantName;
            restInfo.restaurantLocation = RestaurantInfo.restaurantLocation;
            restInfo.ContactNumber = RestaurantInfo.ContactNumber;

            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            Restaurant_info restInfo = this.context.Restaurant_info.SingleOrDefault(x => x.Id == id);
            this.context.Restaurant_info.Remove(restInfo);

            this.context.SaveChanges();
        }
    }
}
