using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Area_Info_Service : iArea_Info_Service
    {
        private iArea_Info_DataAccess data;

        public  Area_Info_Service(iArea_Info_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Area_Info> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Area_Info GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }
    
    }
}
