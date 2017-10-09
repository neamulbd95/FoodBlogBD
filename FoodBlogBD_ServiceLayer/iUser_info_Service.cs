using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iUser_info_Service
    {
        IEnumerable<User_info> GetAllValues();
        User_info GetSingle(int id);
        User_info GetByUserName(string userName);
        void Insert(User_info user_info);
        void Update(User_info user_info);
        void Delete(int id);
    }
}
