using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First
{
    class MyDbContext :DbContext
    {
        public MyDbContext() : base("name=MDSConString") { }

        public virtual DbSet<Broker> Brokers { get; set; }
    }
}
