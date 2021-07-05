using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    public class ProduceType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProduceName> ProduceNames { get; set; }


        public ProduceType()
        {
            ProduceNames = new Collection<ProduceName>();
        }

    }
}
