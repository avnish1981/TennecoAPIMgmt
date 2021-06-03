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
        public Vendor GetVendorByID(int id)
        {
            Vendor vendor = entities.Vendors.FirstOrDefault(a => a.id == id);
            return vendor;
        }
        public void Insertvendor(Vendor vendor )
        {
            entities.Vendors.Add(vendor);
            entities.SaveChanges();
        }

        public Vendor Updatevendor(int id,Vendor vendor )
        {
            Vendor existingVendor = entities.Vendors.FirstOrDefault(a => a.id == id);
            existingVendor.id = vendor.id;
            existingVendor.Name = vendor.Name;
            existingVendor.Location = vendor.Location;
            entities.SaveChanges();
            return existingVendor;
                
        }

        public Vendor DeleteVendor(int id)
        {
            Vendor existingVendor = entities.Vendors.FirstOrDefault(a => a.id == id);
            entities.Vendors.Remove(existingVendor);
            entities.SaveChanges();
            return existingVendor;
        }

        
    } 
}