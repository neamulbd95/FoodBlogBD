using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_Authentication
    {
        [Key]
        public int Id { get; set; }       

        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
