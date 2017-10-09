using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iUser_Post_DataAccess
    {
        IEnumerable<User_Post> GetGetAllValues();
        IEnumerable<User_Post> GetByUser(int userID);
        IEnumerable<User_Post> GetByContent(string search);
        IEnumerable<User_Post> GetByDateRange(DateTime from, DateTime to);
        User_Post GetSingle(int id);
        void Insert(User_Post User_Post);
        void Update(User_Post User_Post);
        void DeleteByUser(int userID);
        void DeleteSingle(int id);

    }
}
