using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting
{

    public class Context: DbContext
    {
        public DbSet<DateHolder> Dates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlServer("data source=STAT_Sam;initial catalog=Testing;trusted_connection=true;TrustServerCertificate=True;Integrated Security=true;MultipleActiveResultSets=true");
    }
    public class DateHolder
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
    }
}
