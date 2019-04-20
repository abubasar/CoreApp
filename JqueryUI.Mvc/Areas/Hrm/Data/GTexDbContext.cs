using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JqueryUI.Mvc.Areas.Hrm.Models;

namespace JqueryUI.Mvc.Models
{
    public class GTexDbContext : DbContext
    {
        public GTexDbContext (DbContextOptions<GTexDbContext> options)
            : base(options)
        {
        }

        public DbSet<JqueryUI.Mvc.Areas.Hrm.Models.Department> Department { get; set; }
    }
}
