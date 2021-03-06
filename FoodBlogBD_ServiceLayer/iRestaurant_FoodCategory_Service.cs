﻿using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iRestaurant_FoodCategory_Service
    {
        IEnumerable<Restaurant_FoodCategory> GetByRestaurant(int restaurantID);
        IEnumerable<Restaurant_FoodCategory> GetByCategory(int categoryID);
        void Insert(Restaurant_FoodCategory Restaurant_FoodCategory);
        //void Update(Restaurant_FoodCategory Restaurant_FoodCategory);
        void DeleteByRestaurant(int restaurantID);
    }
}
