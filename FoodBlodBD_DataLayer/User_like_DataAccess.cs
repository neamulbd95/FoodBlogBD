using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodBlodBD_DataLayer
{
    class User_like_DataAccess : iUser_like_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_like_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_like> GetAllByPost(int id)
        {
            return this.context.User_like.Where(x => x.postID == id).ToList();
        }
        public IEnumerable<User_like> GetAllByUser(int id)
        {
            return this.context.User_like.Where(x => x.userID == id).ToList();
        }
        public User_like GetSingle(int postID, int userID)
        {
            return this.context.User_like.SingleOrDefault(x => x.postID == postID && x.userID == userID);
        }
        public void Insert(User_like User_Like)
        {
            this.context.User_like.Add(User_Like);
            this.context.SaveChanges();
        }
        public void Update(User_like User_Like)
        {
            User_like uLike = this.context.User_like.SingleOrDefault(x => x.postID == User_Like.postID && x.userID == User_Like.userID);
            //uLike.totalLike = User_Like.totalLike;

            this.context.SaveChanges();
        }
        public void DeleteSingle(int postId, int userID)
        {
            User_like uLike = this.context.User_like.SingleOrDefault(x => x.postID == postId && x.userID == userID);
            this.context.User_like.Remove(uLike);

            this.context.SaveChanges();
        }
        public void DeleteByPost(int postId)
        {
            List<User_like> uLike = this.context.User_like.Where(x => x.postID == postId).ToList();
            this.context.User_like.RemoveRange(uLike);

            this.context.SaveChanges();
        }
        public void DeleteByUser(int userID)
        {
            List<User_like> uLike = this.context.User_like.Where(x => x.userID == userID).ToList();
            this.context.User_like.RemoveRange(uLike);

            this.context.SaveChanges();
        }
    }
}
