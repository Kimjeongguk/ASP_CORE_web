using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class User
    {
        [Key]
        [Column(Order =1)]
        public int UserNo { get; set; }
        [Key]
        [Column(Order = 2)]
        public string UserId { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public string UserNickname { get; set; }
    }
}
