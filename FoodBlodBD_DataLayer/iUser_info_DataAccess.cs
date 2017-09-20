using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iUser_info_DataAccess
    {
        IEnumerable<User_info> GetAllValues();
        User_info GetSingle(int id);
        void Insert(User_info user_info);
        void Update(User_info user_info);
        void Delete(int id);
    }
}
