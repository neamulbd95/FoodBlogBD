using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iUser_like_Service
    {
        IEnumerable<User_like> GetAllByPost(int id);
        IEnumerable<User_like> GetAllByUser(int id);
        User_like GetSingle(int postID, int userID);
        void Insert(User_like User_Like);
        void Update(User_like User_Like);
        void DeleteSingle(int postID, int userID);
        void DeleteByPost(int postId);
        void DeleteByUser(int userID);
    }
}
