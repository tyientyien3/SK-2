using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SK_2.Models
{
    public class User
    {
        [DisplayName("ユーザーID")]
        [Key]
        [StringLength(15)]
        public int UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string Mail { get; set; }

        [Required]
        [StringLength(50)]
        public string PAssword { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        public UserType UserType { get; set; }



    }
}
