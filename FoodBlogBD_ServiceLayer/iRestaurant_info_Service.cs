using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iRestaurant_info_Service
    {
        IEnumerable<Restaurant_info> GetAllValues();
        //IEnumerable<Restaurant_info> GetByArea(string areaName);
        Restaurant_info GetSingle(int id);
        void Insert(Restaurant_info Restaurant_info);
        void Update(Restaurant_info Restaurant_info);
        void Delete(int id);
    }
}
