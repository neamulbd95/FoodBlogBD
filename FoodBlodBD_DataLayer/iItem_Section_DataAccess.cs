using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iItem_Section_DataAccess
    {
        IEnumerable<Item_Section> GetByCategory(int categoryID);
        Item_Section GetSingle(int id);
        void Insert(Item_Section Item_Section);
        void Update(Item_Section Item_Section);
        void Delete(int id);
    }
}
