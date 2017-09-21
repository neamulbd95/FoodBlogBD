﻿using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iUser_Authentication_Service
    {
        User_Authentication GetSingle(string username, string password);
        void Insert(User_Authentication user_authentication);
        void Update(User_Authentication user_authentication);
        void Delete(int userId);
    }
}