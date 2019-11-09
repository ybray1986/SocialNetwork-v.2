using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialNetwork.WEB.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public PartialViewResult Post()
        {
            return PartialView();
        }
    }
}