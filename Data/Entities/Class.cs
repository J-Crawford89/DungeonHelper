using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public string ClassDescription { get; set; }
        [Required]
        public string HitDie { get; set; }
        [Required]
        public List<AbilityScores> SavingThrows { get; set; }
        [Required]
        public ICollection<string> ClassEquipment { get; set; }
    }
}
