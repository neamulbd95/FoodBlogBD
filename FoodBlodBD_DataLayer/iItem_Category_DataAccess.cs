﻿using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iItem_Category_DataAccess
    {
        IEnumerable<Item_Category> GetAllValues();
        Item_Category GetSingle(int id);
        Item_Category GetByNameSingle(string name);
        void Insert(Item_Category Item_Category);
        void Update(Item_Category Item_Category);
        void Delete(int id);
    }
}
