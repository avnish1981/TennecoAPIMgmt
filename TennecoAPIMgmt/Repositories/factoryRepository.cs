using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennecoAPIMgmt.Models;

namespace TennecoAPIMgmt.Repositories
{
    public class factoryRepository
    {
        ApplicationDbContext entities = new ApplicationDbContext();

        public List<factory > GetAllfactories()
        {
            return entities.Factories .ToList();
        }
        public factory GetfactoryByID(int factoryid)
        {
            factory factory = entities.Factories .FirstOrDefault(a => a.factoryId  == factoryid);
            return factory;
        }
        public void Insertfactory(factory factory )
        {
            entities.Factories .Add(factory);
            entities.SaveChanges();
        }

        public factory Updatefactory(int factoryid, factory factory)
        {
            factory existingfactory = entities.Factories.FirstOrDefault(a => a.factoryId == factoryid);
            existingfactory.factoryId  = factory.factoryId;
            existingfactory.factoryName = factory.factoryName;
            existingfactory.factoryType = factory.factoryType;
            existingfactory.location = factory.location;
            entities.SaveChanges();
            return existingfactory;

        }

        public factory DeleteVendor(int factoryid)
        {
            factory existingfactory = entities.Factories.FirstOrDefault(a => a.factoryId == factoryid);
            entities.Factories.Remove(existingfactory);
            entities.SaveChanges();
            return existingfactory;
        }
    }
}