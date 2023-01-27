using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperEventos.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public string Place { get; set; }

        public string DataEvent { get; set; }

        public string Theme { get; set; }

        public int Quantity { get; set; }

        public string ImageURL { get; set; }

         public string Address { get; set; }

        
    }
}