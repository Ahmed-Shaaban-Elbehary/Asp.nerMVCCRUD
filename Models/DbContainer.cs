using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.nerMVCCRUD.Models
{
    public class DbContainer:DbContext
    {
        public DbContainer(DbContextOptions<DbContainer> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
