using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MusicDemo.Models;

namespace MusicDemo.Api
{
    public class AlbumsByGenreController : BaseApiController
    {
        // GET /api/albumsbygenre/5
        public IEnumerable<Album> Get(int id)
        {
            return entities.Albums.Where(album => album.GenreId == id);
        }
    }
}
