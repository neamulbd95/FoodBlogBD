using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_info_Service : iUser_info_Service
    {
        private iUser_info_DataAccess data;

        public  User_info_Service(iUser_info_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_info> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public User_info GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }

        public User_info GetByUserName(string userName)
        {
            return this.data.GetByUserName(userName);
        }
        public void Insert(User_info user_info)
        {
            this.data.Insert(user_info);
        }
        public void Update(User_info user_info) 
        {
            this.data.Update(user_info);
        }
        public void Delete(int id)
        {
            this.data.Delete(id);
        }
    }
}
