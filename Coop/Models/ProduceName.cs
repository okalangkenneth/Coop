using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    [Table("ProduceName")]
    public class ProduceName
    {   
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ProduceType ProduceType { get; set; }
        public int ProduceTypeId { get; set; }
    }
}
