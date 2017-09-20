using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodBlodBD_DataLayer
{
    class User_Comment_DataAccess : iUser_Comment_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_Comment_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_Comment> GetComments(int id)
        {
            return this.context.User_Comment.Where(x => x.postID == id);
        }
        public void Insert(User_Comment User_Comment)
        {
            this.context.User_Comment.Add(User_Comment);

            this.context.SaveChanges();
        }
        public void Update(User_Comment User_Comment)
        {
            User_Comment uComment = this.context.User_Comment.SingleOrDefault(x => x.Id == User_Comment.Id);
            uComment.commentContent = User_Comment.commentContent;

            this.context.SaveChanges();
        }
        public void delete(int id)
        {
            User_Comment uComment = this.context.User_Comment.SingleOrDefault(x => x.Id == id);
            this.context.User_Comment.Remove(uComment);

            this.context.SaveChanges();
        }
        public void deleteByPost(int id)
        {
            IEnumerable<User_Comment> uComment = this.context.User_Comment.Where(x => x.Id == id);
            this.context.User_Comment.RemoveRange(uComment);

            this.context.SaveChanges();
        }
        public void deleteByUser(int userid)
        {
            IEnumerable<User_Comment> uComment = this.context.User_Comment.Where(x => x.userID == userid);
            this.context.User_Comment.RemoveRange(uComment);

            this.context.SaveChanges();
        }
    }
}
