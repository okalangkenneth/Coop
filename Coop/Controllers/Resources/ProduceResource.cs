using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Coop.Controllers.Resources
{
    public class ProduceResource
    {
        public int Id { get; set; }
        public KeyValuePairResource ProduceName { get; set; }
        public KeyValuePairResource ProduceType { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<KeyValuePairResource> Features { get; set; }

        public ProduceResource()
        {
            Features = new Collection<KeyValuePairResource>();
        }
    }
}
