using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Repository.Entities
{
    public class Topic
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string TopicName { get; set; } = "";
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
