using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Items
{
    public abstract class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string ItemDescription { get; set; }
        [Required]
        public string ItemPrice { get; set; }
        [Required]
        public double ItemWeightInPounds { get; set; }
        [ForeignKey("ItemProperties")]
        public ICollection<int> ItemPropertyIds { get; set; }
        public virtual ICollection<Property> ItemProperties { get; set; }
    }
}
