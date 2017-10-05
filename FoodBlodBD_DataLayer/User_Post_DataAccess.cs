using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class User_Post_DataAccess : iUser_Post_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_Post_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_Post> GetGetAllValues()
        {
            return this.context.User_Post.ToList();
        }
        public IEnumerable<User_Post> GetByUser(int userID)
        {
            return this.context.User_Post.Where(x => x.userID == userID);
        }
        public IEnumerable<User_Post> GetByContent(string search)
        {
            return this.context.User_Post.Where(x => x.postContent.Contains(search) || x.postHeadline.Contains(search));
        }
        public User_Post GetSingle(int id)
        {
            return this.context.User_Post.SingleOrDefault(x=> x.Id ==id);
        }
        public void Insert(User_Post User_Post)
        {
            this.context.User_Post.Add(User_Post);
            this.context.SaveChanges();
        }
        public void Update(User_Post UserPost)
        {
            User_Post uPost = this.context.User_Post.SingleOrDefault(x => x.Id == UserPost.Id && x.userID == UserPost.userID);
            uPost.postHeadline = UserPost.postHeadline;
            uPost.postContent = UserPost.postContent;
        }
        public void DeleteByUser(int userID)
        {
            IEnumerable<User_Post> uPost = this.context.User_Post.Where(x => x.userID == userID);
            this.context.User_Post.RemoveRange(uPost);

            this.context.SaveChanges();
        }
        public void DeleteSingle(int id)
        {
            User_Post uPost = this.context.User_Post.SingleOrDefault(x => x.Id == id);
            this.context.User_Post.Remove(uPost);

            this.context.SaveChanges();
        }
    }
}
