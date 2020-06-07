using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities.Items
{
    public class Weapon : Item
    {
        [Required]
        public WeaponCategory WeaponCategory { get; set; }
        [Required]
        public string Damage { get; set; }
    }
}
