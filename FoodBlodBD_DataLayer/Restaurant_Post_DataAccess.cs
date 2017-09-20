using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_Post_DataAccess : iRestaurant_Post_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_Post_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant_Post> GetByRestaurant(int restaurantID)
        {
            return this.context.Restaurant_Post.Where(x => x.restuarantID == restaurantID).ToList();
        }
        public void Insert(Restaurant_Post restaurantPost)
        {
            this.context.Restaurant_Post.Add(restaurantPost);
            this.context.SaveChanges();
        }
        public void Upadate(Restaurant_Post restaurantPost)
        {
            Restaurant_Post post = this.context.Restaurant_Post.SingleOrDefault(x => x.Id == restaurantPost.Id);
            post.RestpostHeadline = restaurantPost.RestpostHeadline;
            post.RestpostContent = restaurantPost.RestpostContent;

            this.context.SaveChanges();
        }
        public void DeleteAll(int restaurantID)
        {
            Restaurant_Post post = this.context.Restaurant_Post.SingleOrDefault(x => x.restuarantID == restaurantID);
            this.context.Restaurant_Post.Remove(post);

            this.context.SaveChanges();
        }
        public void DeleteSingle(int id)
        {
            Restaurant_Post post = this.context.Restaurant_Post.SingleOrDefault(x => x.Id == id);
            this.context.Restaurant_Post.Remove(post);

            this.context.SaveChanges();
        }
    }
}
