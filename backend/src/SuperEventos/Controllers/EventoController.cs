using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SuperEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      
        public EventoController()
        {
           
        }

        [HttpGet]
        public string Get()
        {
           return "value Get";
        }

         [HttpPost]
        public string Post()
        {
           return "value Post";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
           return "value Put";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return "value Delete";
        }
    }
}
