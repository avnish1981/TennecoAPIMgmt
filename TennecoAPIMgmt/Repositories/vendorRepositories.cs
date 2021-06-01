using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennecoAPIMgmt.Models;

namespace TennecoAPIMgmt.Repositories
{
    public class vendorRepositories
    {
        ApplicationDbContext entities = new ApplicationDbContext();

        public List<Vendor > GetAllVendors()
        {
            return entities.Vendors.ToList();
        }
        public void Insertvendor(Vendor vendor )
        {
            entities.Vendors.Add(vendor);
            entities.SaveChanges();
        }
    }
}