using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    public interface iItem_Section_Service
    {
        IEnumerable<Item_Section> GetByCategory(int categoryID);
        Item_Section GetSingle(int id);
        void Insert(Item_Section Item_Section);
        void Update(Item_Section Item_Section);
        void Delete(int id);
    }
}
