using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public  interface iArea_Info_DataAccess
    {
        IEnumerable<Area_Info> GetAllValues();
        Area_Info GetSingle(int id);
    }
}
