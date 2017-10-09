using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public abstract class DataAccess_Center
    {
        public static iUser_info_DataAccess GetUser_info_DataAccess()
        {
            return new User_info_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iUser_Authentication_DataAccess GetUser_Authentication_DataAccess()
        {
            return new User_Authentication_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iUser_Post_DataAccess GetUser_Post_DataAccess()
        {
            return new User_Post_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iUser_Comment_DataAccess GetUser_Comment_DataAccess()
        {
            return new User_Comment_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iUser_like_DataAccess GetUser_like_DataAccess()
        {
            return new User_like_DataAccess(new FoodBlogBD_databaseContext());
        }


        public static iUser_Message_DataAccess GetUser_Message_DataAccess()
        {
            return new User_Message_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iUser_Post_Approval_DataAccess GetUser_Post_Approval_DataAccess()
        {
            return new User_Post_Approval_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iRestaurant_info_DataAccess GetRestaurant_info_DataAccess()
        {
            return new Restaurant_info_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static irestaurant_Branch_DataAccess GetRestaurant_Branch_DataAccess()
        {
            return new Restaurant_Branch_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static irestaurantItems_DataAccess GetRestaurantItem_DataAccess()
        {
            return new RestaurantItem_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iRestaurant_FoodCategory_DataAccess GetRestaurant_FoodCategory_DataAccess()
        {
            return new Restaurant_FoodCategory_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iItem_Category_DataAccess GetItem_Category_DataAccess()
        {
            return new Item_Category_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iItem_Section_DataAccess GetItem_Section_DataAccess()
        {
            return new Item_Section_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iRestaurant_Post_DataAccess GetRestaurant_Post_DataAccess()
        {
            return new Restaurant_Post_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iArea_Info_DataAccess GetArea_Info_DataAccess()
        {
            return new Area_Info_DataAccess(new FoodBlogBD_databaseContext());
        }

        public static iRestaurant_Coordinate_DataAcccess GetRestaurant_Coordinate_DataAcccess()
        {
            return new Restaurant_Coordinate_DataAcccess(new FoodBlogBD_databaseContext());
        }

        public static iRestaurant_user_Review_DataAccess GetRestaurant_user_Review_DataAccess()
        {
            return new Restaurant_user_Review_DataAccess(new FoodBlogBD_databaseContext());
        }
    }
}
