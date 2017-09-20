using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_Post_Approval
    {
        [Key]
        public int Id { get; set; }
        public int postId { get; set; }
        public int checkApproval { get; set; } // 0 -> false & 1 -> true 
    }
}
