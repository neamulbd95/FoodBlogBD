using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_Rating_Service : iRestaurant_Rating_Service
    {
        private iRestaurant_Rating_DataAccess data;

        public Restaurant_Rating_Service(iRestaurant_Rating_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_Rating> GetTopRatings()
        {
            return this.data.GetTopRatings();
        }
        public Restaurant_Rating GetSingle(int restaurantID)
        {
            return this.data.GetSingle(restaurantID);
        }
        public void Insert(Restaurant_Rating Restaurant_Rating)
        {
            this.data.Insert(Restaurant_Rating);
        }
        public void Update(Restaurant_Rating Restaurant_Rating)
        {
            this.data.Update(Restaurant_Rating);
        }
        public void Delete(int restaurantID)
        {
            this.data.Delete(restaurantID);
        }
    }
}
