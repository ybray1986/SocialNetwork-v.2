using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialNetwork.WEB.Controllers
{
    public class PostController : ApiController
    {
        [HttpGet]
        IHttpActionResult Post(int id)
        {
            return Ok();
        }
    }
}
