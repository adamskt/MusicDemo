using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Api
{
    public class GenresController : BaseApiController
    {
        // GET /api/genres
        public IEnumerable<Genre> Get()
        {
            return entities.Genres;
        }

        // GET /api/genres/5
        public Genre Get(int id)
        {
            return entities.Genres.FirstOrDefault(genre => genre.GenreId == id);
        }

        // POST /api/genres
        public void Post(string value)
        {
        }

        // PUT /api/genres/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/genres/5
        public void Delete(int id)
        {
        }
    }
}
