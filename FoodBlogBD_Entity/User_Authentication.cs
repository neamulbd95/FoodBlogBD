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
        public int userID { get; set; }
        [MinLength(6)]
        public string passWord { get; set; }

        [ForeignKey("userID")]        
        public virtual User_info User_info { get; set; }
    }
}
