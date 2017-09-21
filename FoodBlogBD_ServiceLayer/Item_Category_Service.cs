using FoodBlogBD_Entity;
using FoodBlodBD_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlogBD_ServiceLayer
{
    class Item_Category_Service : iItem_Category_Service
    {
        private iItem_Category_DataAccess data;

        public Item_Category_Service(iItem_Category_DataAccess data)
        {
            this.data = data;
        }

        public IEnumerable<Item_Category> GetAllValues()
        {
            return this.data.GetAllValues();
        }
        public Item_Category GetSingle(int id)
        {
            return this.data.GetSingle(id);
        }
        public Item_Category GetByNameSingle(string name)
        {
            return this.data.GetByNameSingle(name);
        }
        public void Insert(Item_Category Item_Category)
        {
            this.data.Insert(Item_Category);
        }
        public void Update(Item_Category Item_Category)
        {
            this.data.Update(Item_Category);
        }
        public void Delete(int id)
        {
            this.data.Delete(id);
        }

    }
}
