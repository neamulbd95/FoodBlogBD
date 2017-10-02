using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public abstract class Service_Center
    {
        public static iUser_info_Service GetUser_info_Service()
        {
            return new User_info_Service(DataAccess_Center.GetUser_info_DataAccess());
        }

        public static iUser_Authentication_Service GetUser_Authentication_Service() 
        {
            return new User_Authentication_Service(DataAccess_Center.GetUser_Authentication_DataAccess());
        }

        public static iUser_Post_Service GetUser_Post_Service()
        {
            return new User_Post_Service(DataAccess_Center.GetUser_Post_DataAccess());
        }

        public static iUser_Comment_Service GetUser_Comment_Service()
        {
            return new User_Comment_Service(DataAccess_Center.GetUser_Comment_DataAccess());
        }

        public static iUser_like_Service GetUser_like_Service()
        {
            return new User_like_Service(DataAccess_Center.GetUser_like_DataAccess());
        }

        public static iUser_Message_Service GetUser_Message_Service()
        {
            return new User_Message_Service(DataAccess_Center.GetUser_Message_DataAccess());
        }

        public static iUser_Post_Approval_Service GetUser_Post_Approval_Service()
        {
            return new User_Post_Approval_Service(DataAccess_Center.GetUser_Post_Approval_DataAccess());
        }

        public static iRestaurant_info_Service GetRestaurant_info_Service()
        {
            return new Restaurant_info_Service(DataAccess_Center.GetRestaurant_info_DataAccess());
        }


        public static irestaurant_Branch_Service GetRestaurant_Branch_Service()
        {
            return new restaurant_Branch_Service(DataAccess_Center.GetRestaurant_Branch_DataAccess());
        }

        public static irestaurantItems_Service GetRestaurantItem_Service()
        {
            return new restaurantItem_Service(DataAccess_Center.GetRestaurantItem_DataAccess());
        }

        public static iItem_Category_Service GetItem_Category_Service()
        {
            return new Item_Category_Service(DataAccess_Center.GetItem_Category_DataAccess());
        }

        public static iItem_Section_Service GetItem_Section_Service()
        {
            return new Item_Section_Service(DataAccess_Center.GetItem_Section_DataAccess());
        }

        public static iRestaurant_FoodCategory_Service GetRestaurant_FoodCategory_Service()
        {
            return new Restaurant_FoodCategory_Service(DataAccess_Center.GetRestaurant_FoodCategory_DataAccess());
        }

        public static iRestaurant_Post_Service GetRestaurant_Post_Service()
        {
            return new Restaurant_Post_Service(DataAccess_Center.GetRestaurant_Post_DataAccess());
        }

        public static iArea_Info_Service GetArea_Info_Service()
        {
            return new Area_Info_Service(DataAccess_Center.GetArea_Info_DataAccess());
        }
    }
}
