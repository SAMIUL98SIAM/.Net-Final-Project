using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductBookController : ApiController
    {
        [Route("api/ProductBook/Get")]
        [HttpGet]
        public List<ProductBookModel> Get()
        {
            return ProductBookService.Get();
        }
    }
}
