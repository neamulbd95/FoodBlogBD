using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Area_Info_DataAccess : iArea_Info_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public  Area_Info_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Area_Info> GetAllValues()
        {
            return this.context.Area_Info.ToList();
        }
        public Area_Info GetSingle(int id)
        {
            return this.context.Area_Info.SingleOrDefault(x => x.Id == id);
        }
    }
}
