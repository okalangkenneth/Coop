using Coop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Controllers.Resources
{
    public class ProduceTypeResource
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        public ICollection<ProduceNameResource> ProduceNames { get; set; }


        public ProduceTypeResource()
        {
            ProduceNames = new Collection<ProduceNameResource>();
        }
    }
}
