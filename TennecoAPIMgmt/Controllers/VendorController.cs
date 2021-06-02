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
    public class VendorController : ApiController
    {
        vendorRepositories vendorRepositories = new vendorRepositories();
        
        public IHttpActionResult  GetAllVendors()
        {
            return Ok(vendorRepositories.GetAllVendors());
        }
        public IHttpActionResult GetVendorById(int id)
        {
            return Ok(vendorRepositories.GetVendorByID(id));
        }

        public IHttpActionResult  InsertVendor([FromBody]Vendor vendor)
        {
            if(vendor==null)
            {
                return NotFound();
            }
            else
            {
                vendorRepositories.Insertvendor(vendor);
                return Content(HttpStatusCode.Created, "new vendor inserted");
            }
            
        }
        [HttpPut ]
        public IHttpActionResult UpdateVendor (int id ,[FromBody] Vendor vendor )
        {

            Vendor existingVendor = vendorRepositories.Updatevendor(id, vendor);
            if(existingVendor == null)
            {
                return NotFound();
            }
            else
            {                
                return Content(HttpStatusCode.OK, " vendor updated");
            }
        }
        [HttpDelete ]
        public IHttpActionResult DeleteVendor (int id)
        {
            Vendor existingVendor = vendorRepositories.DeleteVendor(id);
            if (existingVendor == null)
            {
                return NotFound();
            }
            else
            {
                return Content(HttpStatusCode.OK , " vendor deleted");
            }
        }
    }
}
