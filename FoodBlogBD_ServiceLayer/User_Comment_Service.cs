using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class User_Comment_Service : iUser_Comment_Service
    {
        private iUser_Comment_DataAccess data;

        public User_Comment_Service(iUser_Comment_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<User_Comment> GetComments(int id)
        {
            return this.data.GetComments(id);
        }
        public void Insert(User_Comment User_Comment)
        {
            this.data.Insert(User_Comment);
        }
        public void Update(User_Comment User_Comment)
        {
            this.data.Update(User_Comment);
        }
        public void delete(int id)
        {
            this.data.delete(id);
        }
        public void deleteByPost(int id)
        {
            this.data.deleteByPost(id);
        }
        public void deleteByUser(int id)
        {
            this.data.deleteByUser(id);
        }

    }
}
