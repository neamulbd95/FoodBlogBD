using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string userName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Characters are allowed.")]
        public string fullName { get; set; }
        [Required]
        //[DataType(DataType.EmailAddress)]      
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Enter A Valid Email.")] 
        public string email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string profilePicture { get; set; }

        public virtual User_Authentication user_Authentications { get; set; }
        public virtual List<User_Post> User_Post { get; set; }
        public virtual List<User_Comment> User_Comment { get; set; }
        public virtual List<User_like> User_like { get; set; }

    }
}
