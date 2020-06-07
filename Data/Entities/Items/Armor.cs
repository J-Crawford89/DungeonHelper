using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities.Items
{
    public class Armor : Item
    {
        [Required]
        public ArmorCategory ArmorCategory { get; set; }
        [Required]
        public string ArmorClass { get; set; }
        [Required]
        public bool StealthDisadvantage { get; set; }
        [Required]
        public string StrengthRequirement { get; set; }
    }
}
