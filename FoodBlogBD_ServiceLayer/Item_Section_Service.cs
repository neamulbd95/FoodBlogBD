using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Item_Section_Service : iItem_Section_Service
    {
        iItem_Section_DataAccess data;
        
        public Item_Section_Service(iItem_Section_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Item_Section> GetByCategory(int categoryID)
        {
            return this.data.GetByCategory(categoryID);
        }
        public Item_Section GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }
        public void Insert(Item_Section Item_Section)
        {
            this.data.Insert(Item_Section);
        }
        public void Update(Item_Section Item_Section)
        {
            this.data.Update(Item_Section);
        }
        public void Delete(int id)
        {
            this.data.Delete(id);
        }

    }
}
