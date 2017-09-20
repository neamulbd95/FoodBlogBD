using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iUser_Post_Approval_DataAccess
    {
        IEnumerable<User_Post_Approval> GetAllValues();
        User_Post_Approval GetSingle(int postID);
        void Insert(User_Post_Approval approval);
        void Update(User_Post_Approval approval);
        void Delete(int postID);
    }
}
