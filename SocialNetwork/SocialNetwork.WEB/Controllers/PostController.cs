using SocialNetwork.WEB.Entity;
using SocialNetwork.WEB.Repositories;
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
        private IRepository<Post> repo;
        public PostController(IRepository<Post> repoParam)
        {
            repo = repoParam;
        }
        [HttpGet]
        IHttpActionResult Post(int id)
        {
            return Ok();
        }
        IHttpActionResult GetAll()
        {
            repo.GetAll();
            return Ok(repo);
        }
    }
}
