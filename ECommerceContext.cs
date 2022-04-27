using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntitityFramework
{
    public class ECommerceContext: DbContext
    {
        public DbSet<Product> Produts { get; set; }

    }
}
