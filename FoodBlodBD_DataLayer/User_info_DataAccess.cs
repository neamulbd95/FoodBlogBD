using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class User_info_DataAccess : iUser_info_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public User_info_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<User_info> GetAllValues()
        {
            return this.context.User_info.ToList();
        }

        public User_info GetSingle(int id)
        {
            return this.context.User_info.SingleOrDefault(x => x.Id == id);
        }

        public User_info GetByUserName(string userName)
        {
            return this.context.User_info.SingleOrDefault(x => x.userName == userName);
        }
        public void Insert(User_info user_info)
        {
            this.context.User_info.Add(user_info);
            this.context.SaveChanges();
        }

        public void Update(User_info user_info)
        {
            User_info user = this.context.User_info.SingleOrDefault(x => x.Id == user_info.Id);
            user.fullName = user_info.fullName;
            user.profilePicture = user_info.profilePicture;

            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            User_info user = this.context.User_info.SingleOrDefault(x => x.Id == id);
            this.context.User_info.Remove(user);

            this.context.SaveChanges();
        }
    }
}
