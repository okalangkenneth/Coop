using AutoMapper;
using Coop.Controllers.Resources;
using Coop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ProduceType, ProduceTypeResource>();
            CreateMap<ProduceName, ProduceNameResource>();
        }
    }
}
