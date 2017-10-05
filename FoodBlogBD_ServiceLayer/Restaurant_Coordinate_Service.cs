using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_Coordinate_Service : iRestaurant_Coordinate_Service
    {
        private iRestaurant_Coordinate_DataAcccess data;

        public Restaurant_Coordinate_Service(iRestaurant_Coordinate_DataAcccess data)
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_Coordinate> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public IEnumerable<Restaurant_Coordinate> GetRange(double lati, double longi)
        {
            return this.data.GetRange(lati,longi);
        }
        public Restaurant_Coordinate GetSingle(int restId)
        {
            return this.data.GetSingle(restId);
        }
        public void Insert(Restaurant_Coordinate RestaurantCoordinate)
        {
            this.data.Insert(RestaurantCoordinate);
        }
        public void Update(Restaurant_Coordinate RestaurantCoordinate)
        {
            this.data.Update(RestaurantCoordinate);
        }
        public void Delete(int restId)
        {
            this.data.Delete(restId);
        }
    }
}
