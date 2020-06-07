using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        [Required]
        public string FeatureName { get; set; }
        [Required]
        public string FeatureDescription { get; set; }
        [ForeignKey("FeatureClasses")]
        public ICollection<int> ClassIds { get; set; }
        public virtual ICollection<Class> FeatureClasses { get; set; }
    }
}
