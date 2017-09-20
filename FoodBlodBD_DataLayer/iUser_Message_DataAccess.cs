using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iUser_Message_DataAccess
    {
        IEnumerable<User_Message> GetAllValues();
        void Insert(User_Message User_Message);
        void Delete(int id);
        void DeleteAll();
    }
}
