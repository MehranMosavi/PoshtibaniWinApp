using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PoshtibaniWinApp
{
    class DB:DbContext
    {
        public DB():base("name=conStr"){}
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Fund> Funds { set; get; }
        public DbSet<Tankhah> Tankhahs { set; get; }
        public DbSet<VersionControl> versions { set; get; }
    }
}
