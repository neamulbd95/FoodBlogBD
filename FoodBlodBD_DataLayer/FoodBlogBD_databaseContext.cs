using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace FoodBlodBD_DataLayer
{
    class FoodBlogBD_databaseContext : DbContext
    {
        public DbSet<User_info> User_info { get; set; }
        public DbSet<User_Authentication> User_Authentication { get; set; }
        public DbSet<User_Post> User_Post { get; set; }
        public DbSet<User_Comment> User_Comment { get; set; }
        public DbSet<User_like> User_like { get; set; }
        public DbSet<User_Message> User_Message { get; set; }
        public DbSet<User_Post_Approval> User_Post_Approval { get; set; }

        public DbSet<Restaurant_info> Restaurant_info { get; set; }
        public DbSet<restaurant_Branch> restaurant_Branch { get; set; }
        public DbSet<restaurantItem> restaurantItems { get; set; }
        public DbSet<Item_Category> Item_Category { get; set; }
        public DbSet<Item_Section> Item_Section { get; set; }
        public DbSet<Restaurant_FoodCategory> Restaurant_FoodCategory { get; set; }
        public DbSet<Restaurant_Post> Restaurant_Post { get; set; }
        public DbSet<Restaurant_Coordinate> Restaurant_Coordinate { get; set; }

        public DbSet<Area_Info> Area_Info { get; set; }

    }
}
