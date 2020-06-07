using Data.Entities.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        [Required]
        public string CharacterName { get; set; }
        [ForeignKey("CharacterRace")]
        [Required]
        public int CharacterRaceId { get; set; }
        public virtual Race CharacterRace { get; set; }
        [ForeignKey("CharacterClass")]
        [Required]
        public int CharacterClassId { get; set; }
        public virtual Class CharacterClass { get; set; }
        [ForeignKey("CharacterBackground")]
        [Required]
        public int CharacterBackgroundId { get; set; }
        public virtual Background CharacterBackground { get; set; }
        [ForeignKey("Inventory")]
        [Required]
        public ICollection<int> InventoryItemIds { get; set; }
        public virtual ICollection<Item> Inventory { get; set; }
    }
}
