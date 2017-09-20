using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Item_Category_DataAccess : iItem_Category_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Item_Category_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Item_Category> GetAllValues()
        {
            return this.context.Item_Category.ToList();
        }
        public Item_Category GetSingle(int id)
        {
            return this.context.Item_Category.SingleOrDefault(x => x.Id == id);
        }
        public Item_Category GetByNameSingle(string name)
        {
            return this.context.Item_Category.SingleOrDefault(x => x.categoryName == name);
        }
        public void Insert(Item_Category Item_Category)
        {
            this.context.Item_Category.Add(Item_Category);
            this.context.SaveChanges();
        }
        public void Update(Item_Category ItemCategory)
        {
            Item_Category category = this.context.Item_Category.SingleOrDefault(x => x.Id == ItemCategory.Id);
            category.categoryName = ItemCategory.categoryName;

            this.context.SaveChanges();

        }
        public void Delete(int id)
        {
            Item_Category category = this.context.Item_Category.SingleOrDefault(x => x.Id == id);
            this.context.Item_Category.Remove(category);

            this.context.SaveChanges();
        }
    }
}
