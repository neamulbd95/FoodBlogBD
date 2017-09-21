using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_Post_Approval_Service : iUser_Post_Approval_Service
    {
        iUser_Post_Approval_DataAccess data;
        
        public User_Post_Approval_Service(iUser_Post_Approval_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_Post_Approval> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public User_Post_Approval GetSingle(int postID)
        {
            return this.data.GetSingle(postID);
        }
        public void Insert(User_Post_Approval approval)
        {
            this.data.Insert(approval);
        }
        public void Update(User_Post_Approval approval)
        {
            this.data.Update(approval);
        }
        public void Delete(int postID)
        {
            this.data.Delete(postID);
        }
    }
}
