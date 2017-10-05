using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FoodBlogBD_Entity
{
    public class Restaurant_Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RestpostHeadline { get; set; }
        [Required]
        public string RestpostContent { get; set; }
        public int restuarantID { get; set; }
        public DateTime postDate { get; set; }

        //[ForeignKey("restuarantID")]
        //public virtual Restaurant_info User_info { get; set; }

    }
}
