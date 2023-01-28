using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperEventos.Models;

namespace SuperEventos.Data
{
    public class DataContext : DbContext
    {

      public DataContext(DbContextOptions<DataContext> option) : base(option) {}

      public DbSet<Event> Eventos{ get; set; }
        
    }
}