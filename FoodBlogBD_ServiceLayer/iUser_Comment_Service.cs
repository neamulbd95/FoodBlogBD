﻿using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iUser_Comment_Service
    {
        IEnumerable<User_Comment> GetComments(int id);
        void Insert(User_Comment User_Comment);
        void Update(User_Comment User_Comment);
        void delete(int id);
        void deleteByPost(int id);
        void deleteByUser(int id);
    }
}
