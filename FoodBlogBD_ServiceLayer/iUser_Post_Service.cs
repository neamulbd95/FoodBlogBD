using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iUser_Post_Service
    {
        IEnumerable<User_Post> GetGetAllValues();
        IEnumerable<User_Post> GetByUser(int userID);
        IEnumerable<User_Post> GetByContent(string search);
        User_Post GetSingle(int id);
        void Insert(User_Post User_Post);
        void Update(User_Post User_Post);
        void DeleteByUser(int userID);
        void DeleteSingle(int id);

    }
}
