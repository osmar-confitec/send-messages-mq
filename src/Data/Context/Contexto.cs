using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
       : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //   builder.ApplyConfiguration(new ArchiveMapping());
        }
    }
}
