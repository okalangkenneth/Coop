using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    public class ProduceName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProduceType ProduceType { get; set; }
        public int ProduceTypeId { get; set; }
    }
}
