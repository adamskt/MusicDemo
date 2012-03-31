using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Controllers
{
    public class ArtistsController : BaseApiController
    {

        // GET /api/artists
        public IEnumerable<Artist> Get()
        {
            return entities.Artists;
        }

        // GET /api/artists/5
        public Artist Get(int id)
        {
            return entities.Artists.FirstOrDefault(artist => artist.ArtistId == id);
        }

        // POST /api/artists
        public void Post(string value)
        {
        }

        // PUT /api/artists/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/artists/5
        public void Delete(int id)
        {
        }
    }
}
