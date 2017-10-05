using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iRestaurant_Coordinate_DataAcccess
    {
        IEnumerable<Restaurant_Coordinate> GetAllValues();
        IEnumerable<Restaurant_Coordinate> GetRange(double lati, double longi);
        Restaurant_Coordinate GetSingle(int restId);
        void Insert(Restaurant_Coordinate RestaurantCoordinate);
        void Update(Restaurant_Coordinate RestaurantCoordinate);
        void Delete(int restId);
    }
}
