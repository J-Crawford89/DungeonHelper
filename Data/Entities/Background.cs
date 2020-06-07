using Data.Entities.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Entities.Enums;

namespace Data.Entities
{
    public class Background
    {
        [Key]
        public int BackgroundId { get; set; }
        [Required]
        public string BackgroundName { get; set; }
        [Required]
        public string BackgroundDescription { get; set; }
        [ForeignKey("BackgroundFeature")]
        [Required]
        public int FeatureId { get; set; }
        public virtual Feature BackgroundFeature { get; set; }
        [ForeignKey("AlternateBackgroundFeature")]
        public int? AlternateFeatureId { get; set; }
        public virtual Feature AlternateBackgroundFeature { get; set; }
        [Required]
        public ICollection<Skills> SkillProficiencies { get; set; }
        [Required]
        public ICollection<string> OtherProficiencies { get; set; }
        [ForeignKey("BackgroundEquipment")]
        [Required]
        public ICollection<int> BackgroundEquipmentIds { get; set; }
        public virtual ICollection<Item> BackgroundEquipment { get; set; }
    }
}
