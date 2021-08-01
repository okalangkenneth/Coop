using Coop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coop.Controllers
{
    [Route("/api/produce")]
    public class ProduceController:Controller
    {
        [HttpPost]
        public IActionResult CreateProduce(Produce produce)
        {
            return Ok(produce);
        }
    }
}
