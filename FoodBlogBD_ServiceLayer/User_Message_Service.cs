using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_Message_Service : iUser_Message_Service
    {
        iUser_Message_DataAccess data;

        public User_Message_Service(iUser_Message_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_Message> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public void Insert(User_Message User_Message)
        {
            this.data.Insert(User_Message);
        }
        public void Delete(int id)
        {
            this.data.Delete(id);
        }
        public void DeleteAll()
        {
            this.data.DeleteAll();
        }

    }
}
