using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iArea_Info_Service
    {
        IEnumerable<Area_Info> GetAllValues();
        Area_Info GetSingle(int id);
    }
}
