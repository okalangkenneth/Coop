using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Models
{
    public class ProduceQuery:IQueryObject
    {
        
       
            public int? ProduceTypeId { get; set; }
            public int? Id { get; set; }
            public string SortBy { get; set; }
            public bool IsSortAscending { get; set; }
            public int Page { get; set; }
            public byte PageSize { get; set; }
        
    }

    public interface IQueryObject
    {
    }
}
