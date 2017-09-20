using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodBlodBD_DataLayer
{
    class User_Message_DataAccess : iUser_Message_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_Message_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_Message> GetAllValues()
        {
            return this.context.User_Message.ToList();
        }
        public void Insert(User_Message User_Message)
        {
            this.context.User_Message.Add(User_Message);
            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            User_Message umsg = this.context.User_Message.SingleOrDefault(x => x.Id == id);
            this.context.User_Message.Remove(umsg);

            this.context.SaveChanges();
        }
        public void DeleteAll()
        {
            IEnumerable<User_Message> umsgAll = this.context.User_Message.ToList();
            this.context.User_Message.RemoveRange(umsgAll);

            this.context.SaveChanges();
        }
    }
}
