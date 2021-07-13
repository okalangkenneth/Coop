using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    [Table("ProduceFeatures")]
    public class ProduceFeature
    {
        public int ProduceId { get; set; }
        public int FeatureId { get; set; }
        public Produce Produce { get; set; }
        public Feature Feature { get; set; }
    }
}
