using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_like_Service : iUser_like_Service
    {
        private iUser_like_DataAccess data;
        
        public User_like_Service(iUser_like_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_like> GetAllByPost(int id)
        {
            return this.data.GetAllByPost(id);
        }
        public IEnumerable<User_like> GetAllByUser(int id)
        {
            return this.data.GetAllByUser(id);
        }
        public User_like GetSingle(int postID, int userID)
        {
            return this.data.GetSingle(postID, userID);
        }
        public void Insert(User_like User_Like)
        {
            this.data.Insert(User_Like);
        }
        public void Update(User_like User_Like)
        {
            this.data.Update(User_Like);
        }
        public void DeleteSingle(int postID, int userID)
        {
            this.data.DeleteSingle(postID,userID);
        }
        public void DeleteByPost(int postId)
        {
            this.data.GetAllByPost(postId);
        }
        public void DeleteByUser(int userID)
        {
            this.data.DeleteByUser(userID);
        }
    }
}
