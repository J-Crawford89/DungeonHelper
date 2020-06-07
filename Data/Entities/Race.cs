using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        [Required]
        public string RaceName { get; set; }
        [Required]
        public string RaceDescription { get; set; }
        [Required]
        public string AbilityScoreIncrease { get; set; }
        [Required]
        public bool HasDarkvision { get; set; }
        [Required]
        public string RaceSpeed { get; set; }
        [Required]
        public string RaceSize { get; set; }
    }
}
