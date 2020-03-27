using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Project.Models
{
    public class Users
    {
        [Key] [Column(Order=1)]
        public int UserNo { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Key] [Column(Order=2)]
        public string UserNickname { get; set; }
    }
}
