using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/Approve/{id}")]
        [HttpPost]
        public void ApproveOrder(int id)
        {
            OrderService.ApproveOrder(id);
        }
        [Route("api/Order/Cancel/{id}")]
        [HttpPost]
        public void CancelOrder(int id)
        {
            OrderService.CancelOrder(id);
        }
    }
}
