using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Restaurant_info_Service : iRestaurant_info_Service
    {
        iRestaurant_info_DataAccess data;

        public Restaurant_info_Service(iRestaurant_info_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Restaurant_info> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Restaurant_info GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }
        public IEnumerable<Restaurant_info> GetTopRated()
        {
            return this.data.GetTopRated();
        }
        public void Insert(Restaurant_info Restaurant_info)
        {
            this.data.Insert(Restaurant_info);
        }
        public void Update(Restaurant_info Restaurant_info)
        {
            this.data.Update(Restaurant_info);
        }
        public void UpdateRating(Restaurant_info Restaurant_info)
        {
            this.data.UpdateRating(Restaurant_info);
        }

        public void Delete(int id)
        {
            this.data.Delete(id);
        }
    }
}
