using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Api
{
    public class AlbumsController : BaseApiController
    {
        // GET /api/albums
        public IEnumerable<Album> Get()
        {
            return entities.Albums;
        }

        // GET /api/albums/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/albums
        public void Post(string value)
        {
        }

        // PUT /api/albums/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/albums/5
        public void Delete(int id)
        {
        }
    }
}
