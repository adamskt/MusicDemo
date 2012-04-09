using System;
using System.Collections.Generic;
using System.Data;
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
        public Album Get(int id)
        {
            return entities.Albums.Include("Artist").SingleOrDefault(album => album.AlbumId == id);
        }

        // POST /api/albums
        public void Post(Album value)
        {
            entities.Albums.Add(value);
            entities.SaveChanges();
        }

        // PUT /api/albums/5
        public void Put(int id, Album value)
        {

            var album = entities.Albums.SingleOrDefault(a => a.AlbumId == id);

            entities.Entry(album).CurrentValues.SetValues(value);
            entities.SaveChanges();
        }

        // DELETE /api/albums/5
        public void Delete(int id)
        {
        }
    }
}
