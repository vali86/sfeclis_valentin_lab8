using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sfeclis_valentin_lab8.Models;

namespace sfeclis_valentin_lab8.Data
{
    public class sfeclis_valentin_lab8Context : DbContext
    {
        public sfeclis_valentin_lab8Context (DbContextOptions<sfeclis_valentin_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<sfeclis_valentin_lab8.Models.Book> Book { get; set; }

        public DbSet<sfeclis_valentin_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<sfeclis_valentin_lab8.Models.Category> Category { get; set; }
    }
}
