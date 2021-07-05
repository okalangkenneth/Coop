using AutoMapper;
using Coop.Controllers.Resources;
using Coop.Data;
using Coop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coop.Controllers
{
    public class ProduceTypesController : Controller
    {
        private readonly CoopDbContext context;
        private readonly IMapper mapper;

        public ProduceTypesController(CoopDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/produceTypes")]
        public async Task <IEnumerable<ProduceTypeResource>>GetProduceTypes()
        {
            var produceTypes = await context.ProduceTypes.Include(m=> m.ProduceNames).ToListAsync();
            return mapper.Map<List<ProduceType>, List<ProduceTypeResource>>(produceTypes);
        }
    }
}
