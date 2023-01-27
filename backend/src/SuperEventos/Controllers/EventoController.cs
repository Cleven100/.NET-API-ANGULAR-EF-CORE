using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperEventos.Models;

namespace SuperEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

       public IEnumerable<Event> _events = new Event[] {
          new Event() {
            EventId = 1,
            Theme = "Angular e .net 7",
            Place = "Rio de janeiro",
            Address = "Rua New York, n10",
            Quantity = 250,
            DataEvent = DateTime.Now.AddDays(2).ToString(),
            ImageURL = "foto.png"

           },
             new Event() {
            EventId = 2,
            Theme = "React e .net 6",
            Place = "Rio de janeiro",
            Address = "Rua New York, n10",
            Quantity = 250,
            DataEvent = DateTime.Now.AddDays(3).ToString(),
            ImageURL = "foto.png"

           }
       };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

         [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _events.Where(events => events.EventId == id);
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
