using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Api
{
    public class TopTenController : BaseApiController
    {
        // GET /api/topten
        public IEnumerable<Album> Get()
        {
            return entities.Albums.Include("Artist").Take(10);
        }

    }
}
