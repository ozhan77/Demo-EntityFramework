using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitityFramework
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Produts.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Produts.Where(p => p.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPrice(string key)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Produts.Where(p => p.UnitPrice>Convert.ToInt16(key)).ToList();
            }
        }
        public void Add(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                context.Produts.Add(product);
                context.SaveChanges();

            }
        }
        public void Update(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
