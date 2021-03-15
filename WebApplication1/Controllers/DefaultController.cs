using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        productEntities db = new productEntities();
        //public string Get()
        //{
        //    return "Welcome to Web API";
        //}
        public List<product> Get()
        {
            return db.products.ToList();
        }
    }
}
