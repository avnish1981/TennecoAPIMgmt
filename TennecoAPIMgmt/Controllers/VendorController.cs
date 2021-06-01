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
    }
}
