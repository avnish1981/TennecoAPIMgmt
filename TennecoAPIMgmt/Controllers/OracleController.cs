using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using TennecoAPIMgmt.Models;
using TennecoAPIMgmt.Repositories;

namespace TennecoAPIMgmt.Controllers
{
    public class OracleController : ApiController
    {
        productRepositories entities = new productRepositories();
       public IHttpActionResult GetAllProduct()
        {
            return Ok(entities.GetAllProduct());
        }
        public IHttpActionResult GetProductById (int id)
        {
           Product product   = entities.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        public IHttpActionResult InsertProduct([FromBody ] Product product )
        {
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                entities.InsertProduct(product);
                return Content(HttpStatusCode.Created, "New Product created");
            }
        }

    }
}
