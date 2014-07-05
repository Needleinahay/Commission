using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class CommissionContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<ContactInfo> ContactInf { get; set; }
    }
}
