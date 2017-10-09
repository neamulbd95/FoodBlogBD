using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_user_Review_DataAccess : iRestaurant_user_Review_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public  Restaurant_user_Review_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_user_Review> GetAllValues()
        {
            return this.context.Restaurant_user_Review.ToList();
        }
        public IEnumerable<Restaurant_user_Review> GetByRestaurant(int restId)
        {
            return this.context.Restaurant_user_Review.Where(x => x.restID == restId);
        }
        public IEnumerable<Restaurant_user_Review> GetByUser(int userId)
        {
            return this.context.Restaurant_user_Review.Where(x=> x.userID == userId);
        }
        public Restaurant_user_Review GetSingle(int Id)
        {
            return this.context.Restaurant_user_Review.SingleOrDefault(x=> x.Id == Id);
        }
        public void Insert(Restaurant_user_Review RestaurantUserReview)
        {
            this.context.Restaurant_user_Review.Add(RestaurantUserReview);

            this.context.SaveChanges();
        }
        public void Update(Restaurant_user_Review RestaurantUserReview)
        {
            Restaurant_user_Review Review = this.context.Restaurant_user_Review.SingleOrDefault(x=> x.Id == RestaurantUserReview.Id);

            Review.ReviewContent = RestaurantUserReview.ReviewContent;

            this.context.SaveChanges();
        }
        public void Delete(int Id)
        {
            Restaurant_user_Review review = this.context.Restaurant_user_Review.SingleOrDefault(x => x.Id == Id);

            this.context.Restaurant_user_Review.Remove(review);
            this.context.SaveChanges();
        }

        public void DeleteByUser(int userID)
        {
            IEnumerable<Restaurant_user_Review> review = this.context.Restaurant_user_Review.Where(x => x.Id == userID);
            this.context.Restaurant_user_Review.RemoveRange(review);
            this.context.SaveChanges();
        }
        public void DeleteByRestaurant(int restID)
        {
            IEnumerable<Restaurant_user_Review> review = this.context.Restaurant_user_Review.Where(x => x.Id == restID);
            this.context.Restaurant_user_Review.RemoveRange(review);
            this.context.SaveChanges();
        }
    }
}
