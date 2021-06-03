using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennecoAPIMgmt.Models;


namespace TennecoAPIMgmt.Repositories
{
    public class productRepositories
    {
        OracleDBContext entities = new OracleDBContext();
        public List<Product> GetAllProduct()
        {
            return entities.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return entities.Products.FirstOrDefault(a => a.Id == id);
        }

        public void InsertProduct(Product product )
        {
           entities.Products.Add(product);
           entities.SaveChanges();

        }

        
    }
}