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
    public class AboutController : ApiController
    {
        [Route("api/About/Get")]
        [HttpGet]
        public List<AboutModel> Get()
        {
            return AboutService.Get();
        }
        [Route("api/About/Create")]
        [HttpPost]
        public void Add(AboutModel about)
        {
            AboutService.Add(about);
        }
        [Route("api/About/Edit")]
        [HttpPost]
        public void Edit(AboutModel about)
        {
            AboutService.Edit(about);
        }
        [Route("api/About/Delete")]
        [HttpPost]
        public void Delete(AboutModel about)
        {
            AboutService.Delete(about);
        }
    }
}
