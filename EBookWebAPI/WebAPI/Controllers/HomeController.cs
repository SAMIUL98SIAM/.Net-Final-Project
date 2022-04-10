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
    public class HomeController : ApiController
    {
        [Route("api/SendMail")]
        [HttpPost]
        public void Contact(ContactModel contact)
        {
            HomeService.Contact(contact);
        }
    }
}
