using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.DAL.Enitity;
using Tamplate.DAL.Extend;

namespace Tamplate.DAL.Database
{
    public class TemplateContext : IdentityDbContext<AppUsers>
    {
        public TemplateContext(DbContextOptions<TemplateContext> options) : base(options) {}

        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Country> Countriy { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
    }
}
