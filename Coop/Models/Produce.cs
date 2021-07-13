using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    [Table("Produce")]
    public class Produce
    {
        public int Id { get; set; }
        public int ProduceNameId { get; set; }
        public ProduceName ProduceName { get; set; }
        public bool IsRegistered { get; set; }
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<ProduceFeature> Features { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public Produce()
        {
            Features = new Collection<ProduceFeature>();
            Photos = new Collection<Photo>();
        }
    }
}