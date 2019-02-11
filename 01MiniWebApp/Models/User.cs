using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniWebApp.Models
{
    public class User
    {
         public int Id { get; set; }
        
         [Required]
         [MinLength(3)]
         public string Name { get; set; }



         [Required]
         [MinLength(6)]
         public string Surname { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Range(0,1)]
        public GenderStatus gender { get; set; }

         


    

}
}
