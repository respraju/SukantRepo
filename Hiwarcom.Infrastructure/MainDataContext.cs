using Hiwarcom.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiwarcom.Infrastructure
{
    public class MainDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
