using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Repository.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? EmailId { get; set; }
        [Required]
        public string? Password { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime Stamp { get; set; }
        public bool Status { get; set; }
    }
}
