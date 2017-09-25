using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_Authentication_Service : iUser_Authentication_Service
    {
        private iUser_Authentication_DataAccess data;

        public User_Authentication_Service(iUser_Authentication_DataAccess data)
        {
            this.data = data;
        }
        public IEnumerable<User_Authentication> GetAllValues()
        {
            return this.data.GetAllValues();
        }

        public User_Authentication GetSingle(string username, string password)
        {
            return this.data.GetSingle(username, password);
        }
        public void Insert(User_Authentication user_authentication)
        {
            this.data.Insert(user_authentication);
        }
        public void Update(User_Authentication user_authentication)
        {
            this.data.Update(user_authentication);
        }
        public void Delete(string userId)
        {
            this.data.Delete(userId);
        }
    }
}
