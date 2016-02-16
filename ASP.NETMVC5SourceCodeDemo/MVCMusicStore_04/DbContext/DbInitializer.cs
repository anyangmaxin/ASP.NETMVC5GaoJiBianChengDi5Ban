using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMusicStore_04.Models;

namespace MVCMusicStore_04.DbContext
{
    public class DbInitializer:System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist() {Name = "Al Di Meola"});
            context.Genres.Add(new Genre() {Name = "Jazz"});
            context.Albums.Add(new Album()
            {
                Artist = new Artist() { Name = "Rush"},
                Genre = new Genre() { Name = "Rock"},
                Price = 9.99m,
                Title = "Caravan"
            });
        }
    }
}