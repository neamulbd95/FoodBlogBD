using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer 
{
    class Restaurant_Rating_DataAccess : iRestaurant_Rating_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_Rating_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_Rating> GetTopRatings()
        {
            return this.context.Restaurant_Rating.OrderByDescending(x => x.avarageRating).Take(6).ToList();
        }
        public Restaurant_Rating GetSingle(int restaurantID)
        {
            return this.context.Restaurant_Rating.SingleOrDefault(x => x.restaurantID == restaurantID);
        }
        public void Insert(Restaurant_Rating Restaurant_Rating)
        {
            this.context.Restaurant_Rating.Add(Restaurant_Rating);
            this.context.SaveChanges();
        }
        public void Update(Restaurant_Rating Restaurant_Rating)
        {
            Restaurant_Rating rating = this.context.Restaurant_Rating.SingleOrDefault(x => x.restaurantID == Restaurant_Rating.restaurantID);
            rating.totalRating = Restaurant_Rating.totalRating;
            rating.ratingGivenUser = Restaurant_Rating.ratingGivenUser;

            this.context.SaveChanges();
        }
        public void Delete(int restaurantID)
        {
            Restaurant_Rating rating = this.context.Restaurant_Rating.SingleOrDefault(x => x.restaurantID == restaurantID);

            this.context.Restaurant_Rating.Remove(rating);
            this.context.SaveChanges();
        }
    }
}
