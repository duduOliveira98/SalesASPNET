using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesForceMVC.Models;

namespace SalesForceMVC.Data
{
    public class SalesForceMVCContext : DbContext
    {
        public SalesForceMVCContext (DbContextOptions<SalesForceMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesForceMVC.Models.Departament> Departament { get; set; }
    }
}
