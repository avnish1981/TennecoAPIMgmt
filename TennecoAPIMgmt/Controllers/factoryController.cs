using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TennecoAPIMgmt.Models;
using TennecoAPIMgmt.Repositories;

namespace TennecoAPIMgmt.Controllers
{
    public class factoryController : ApiController
    {
        factoryRepository factoryRepositories = new factoryRepository();

        public IHttpActionResult GetAllVendors()
        {
            return Ok(factoryRepositories.GetAllfactories());
        }
        public IHttpActionResult GetVendorById(int id)
        {
            return Ok(factoryRepositories.GetfactoryByID(id));
        }

        public IHttpActionResult InsertVendor([FromBody] factory factory)
        {
            if (factory == null)
            {
                return NotFound();
            }
            else
            {
                factoryRepositories.Insertfactory(factory);
                return Content(HttpStatusCode.Created, "new factry inserted");
            }

        }
        [HttpPut]
        public IHttpActionResult UpdateFactory(int id, [FromBody] factory factory)
        {

            factory  existingVendor = factoryRepositories.Updatefactory(id, factory);
            if (existingVendor == null)
            {
                return NotFound();
            }
            else
            {
                return Content(HttpStatusCode.OK, " factory updated");
            }
        }
        [HttpDelete]
        public IHttpActionResult Deletefactory(int id)
        {
            factory  existingVendor = factoryRepositories.DeleteVendor(id);
            if (existingVendor == null)
            {
                return NotFound();
            }
            else
            {
                return Content(HttpStatusCode.OK, " factory deleted");
            }
        }
    }
}
