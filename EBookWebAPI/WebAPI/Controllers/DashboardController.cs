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
    public class DashboardController : ApiController
    {
        [Route("api/Dashboard/CustomerOrders")]
        [HttpGet]
        public List<OrderDetailModel> CustomerOrders()
        {
            return DashboardService.CustomerOrders();
        }
        [Route("api/ProductBook/Activate/{id}")]
        [HttpPost]
        public void Activate(int id)
        {
            DashboardService.Activate(id);
        }
        [Route("api/ProductBook/Unactivate/{id}")]
        [HttpPost]
        public void Unactivate(int id)
        {
            DashboardService.Unctivate(id);
        }

    }
}
