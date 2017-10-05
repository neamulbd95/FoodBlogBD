using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FoodBlodBD_DataLayer
{
    class Item_Section_DataAccess : iItem_Section_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Item_Section_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Item_Section> GetByCategory(int categoryID)
        {
            return this.context.Item_Section.Where(x => x.categoryID == categoryID).ToList();
        }
        public Item_Section GetSingle(int id)
        {
            return this.context.Item_Section.SingleOrDefault(x => x.Id == id);
        }
        public void Insert(Item_Section Item_Section)
        {
            this.context.Item_Section.Add(Item_Section);
        }
        public void Update(Item_Section ItemSection)
        {
            Item_Section section = this.context.Item_Section.SingleOrDefault(x=> x.Id == ItemSection.Id);
            section.sectionName = ItemSection.sectionName;

            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            Item_Section section = this.context.Item_Section.SingleOrDefault(x => x.Id == id);
            this.context.Item_Section.Remove(section);

            this.context.SaveChanges();
        }
        public IEnumerable<Item_Section> searchSection(string keyword)
        {
            return this.context.Item_Section.Where(x => x.sectionName.Contains(keyword));
        }
    }
}
