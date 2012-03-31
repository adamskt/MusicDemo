using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        public BaseApiController()
        {
            entities = new MusicStoreEntities();
        }

        protected MusicStoreEntities entities { get; private set; }
    }
}
