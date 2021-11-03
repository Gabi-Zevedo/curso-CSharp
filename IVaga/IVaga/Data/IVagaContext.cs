using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IVaga.Models;

namespace IVaga.Data
{
    public class IVagaContext : DbContext
    {
        public IVagaContext (DbContextOptions<IVagaContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}
