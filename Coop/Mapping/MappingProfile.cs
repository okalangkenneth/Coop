using AutoMapper;
using Coop.Controllers.Resources;
using Coop.Models;

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
