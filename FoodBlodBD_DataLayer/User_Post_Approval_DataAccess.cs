using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class User_Post_Approval_DataAccess : iUser_Post_Approval_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_Post_Approval_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_Post_Approval> GetAllValues()
        {
            return this.context.User_Post_Approval.ToList();
        }
        public User_Post_Approval GetSingle(int postID)
        {
            return this.context.User_Post_Approval.SingleOrDefault(x => x.postId == postID);
        }
        public void Insert(User_Post_Approval approval)
        {
            this.context.User_Post_Approval.Add(approval);

            this.context.SaveChanges();
        }
        public void Update(User_Post_Approval approval)
        {
            User_Post_Approval app = this.context.User_Post_Approval.SingleOrDefault(x => x.Id == approval.Id);
            app.checkApproval = approval.checkApproval;

            this.context.SaveChanges();
        }
        public void Delete(int postID)
        {
            User_Post_Approval app = this.context.User_Post_Approval.SingleOrDefault(x => x.postId == postID);

            this.context.User_Post_Approval.Remove(app);

            this.context.SaveChanges();
        }
    }
}
