using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Trait
    {
        [Key]
        public int TraitId { get; set; }
        [Required]
        public string TraitName { get; set; }
        [Required]
        public string TraitDescription { get; set; }
        [ForeignKey("Races")]
        public ICollection<int> RaceIds { get; set; }
        [Required]
        public virtual ICollection<Race> Races { get; set; }
    }
}
