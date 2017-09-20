using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBlodBD_DataLayer
{
    public interface iRestaurant_Rating_DataAccess
    {
        IEnumerable<Restaurant_Rating> GetTopRatings();
        Restaurant_Rating GetSingle(int restaurantID);
        void Insert(Restaurant_Rating Restaurant_Rating);
        void Update(Restaurant_Rating Restaurant_Rating);
        void Delete(int restaurantID);
    }
}
