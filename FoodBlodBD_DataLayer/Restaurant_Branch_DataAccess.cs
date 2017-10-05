using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    class Restaurant_Branch_DataAccess : irestaurant_Branch_DataAccess
    {
        private FoodBlogBD_databaseContext context;

        public Restaurant_Branch_DataAccess(FoodBlogBD_databaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<restaurant_Branch> GetByRestaurant(int restaurantID)
        {
            return this.context.restaurant_Branch.Where(x => x.restaurantID == restaurantID).ToList();
        }
        public IEnumerable<restaurant_Branch> GetByLocation(string area)
        {
            return this.context.restaurant_Branch.Where(x => x.branchArea == area);
        }
        public restaurant_Branch GetSingle(int id)
        {
            return this.context.restaurant_Branch.SingleOrDefault(x=> x.Id == id);
        }
        public void Insert(restaurant_Branch restaurant_Branch)
        {
            this.context.restaurant_Branch.Add(restaurant_Branch);
            this.context.SaveChanges();
        }
        public void Update(restaurant_Branch restaurantBranch)
        {
            restaurant_Branch branch = this.context.restaurant_Branch.SingleOrDefault(x => x.Id == restaurantBranch.Id);
            branch.branchName = restaurantBranch.branchName;

            this.context.SaveChanges();

        }
        public void Delete(int restaurantID)
        {
            restaurant_Branch branch = this.context.restaurant_Branch.SingleOrDefault(x => x.Id == restaurantID);
            this.context.restaurant_Branch.Remove(branch);

            this.context.SaveChanges();

        }
        public void DeleteByRestaurant(int restID)
        {
            IEnumerable<restaurant_Branch> branchList = this.context.restaurant_Branch.Where(x => x.restaurantID == restID);

            this.context.restaurant_Branch.RemoveRange(branchList);

            this.context.SaveChanges();
        }
    }
}
