using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_Coordinate_DataAcccess : iRestaurant_Coordinate_DataAcccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_Coordinate_DataAcccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_Coordinate> GetAllValues()
        {
            return this.context.Restaurant_Coordinate.ToList();
        }
        public IEnumerable<Restaurant_Coordinate> GetRange(double lati, double longi)
        {
            return this.context.Restaurant_Coordinate.Where(x => x.latitude <= lati + 0.013 && x.latitude >= lati - 0.013 && x.longitude <= longi + 0.013 && x.longitude >= longi - 0.013);
        }
        public Restaurant_Coordinate GetSingle(int restId)
        {
            return this.context.Restaurant_Coordinate.SingleOrDefault(x=> x.restId == restId);
        }
        public void Insert(Restaurant_Coordinate RestaurantCoordinate)
        {
            this.context.Restaurant_Coordinate.Add(RestaurantCoordinate);

            this.context.SaveChanges();
        }
        public void Update(Restaurant_Coordinate RestaurantCoordinate)
        {
            Restaurant_Coordinate restCo = this.context.Restaurant_Coordinate.SingleOrDefault(x => x.restId == RestaurantCoordinate.restId);

            restCo.latitude = RestaurantCoordinate.latitude;
            restCo.longitude = RestaurantCoordinate.longitude;

            this.context.SaveChanges();
        }
        public void Delete(int restId)
        {
            Restaurant_Coordinate restCo = this.context.Restaurant_Coordinate.SingleOrDefault(x => x.restId == restId);

            this.context.Restaurant_Coordinate.Remove(restCo);

            this.context.SaveChanges();
        }
    }
}
