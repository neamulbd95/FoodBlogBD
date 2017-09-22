using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class User_Authentication_DataAccess : iUser_Authentication_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_Authentication_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public User_Authentication GetSingle(string username, string password)
        {
            return this.context.User_Authentication.SingleOrDefault(x => x.userName == username && x.passWord == password);
        }

        public void Insert(User_Authentication user_authentication)
        {
            this.context.User_Authentication.Add(user_authentication);
            this.context.SaveChanges();
        }

        public void Update(User_Authentication user_authentication)
        {
            User_Authentication user = this.context.User_Authentication.SingleOrDefault(x => x.userName == user_authentication.userName);
            user.passWord = user_authentication.passWord;

            this.context.SaveChanges();
        }
        public void Delete(string userId)
        {
            User_Authentication user = this.context.User_Authentication.SingleOrDefault(x => x.userName == userId);
            this.context.User_Authentication.Remove(user);

            this.context.SaveChanges();
        }
    }
}
