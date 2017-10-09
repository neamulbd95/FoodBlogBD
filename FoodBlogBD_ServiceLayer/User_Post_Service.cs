using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_Post_Service : iUser_Post_Service
    {
        private iUser_Post_DataAccess data;

        public User_Post_Service(iUser_Post_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_Post> GetGetAllValues()
        {
            return this.data.GetGetAllValues();
        }
        public IEnumerable<User_Post> GetByUser(int userID)
        {
            return this.data.GetByUser(userID);
        }
        public IEnumerable<User_Post> GetByContent(string search)
        {
            return this.data.GetByContent(search);
        }
        public IEnumerable<User_Post> GetByDateRange(DateTime from, DateTime to)
        {
            return this.data.GetByDateRange(from, to);
        }

        public User_Post GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }
        public void Insert(User_Post User_Post)
        {
            this.data.Insert(User_Post);
        }
        public void Update(User_Post User_Post)
        {
            this.data.Update(User_Post);
        }
        public void DeleteByUser(int userID)
        {
            this.data.DeleteByUser(userID);
        }
        public void DeleteSingle(int id)
        {
            this.data.DeleteSingle(id);
        }
    }
}
