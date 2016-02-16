using System.Data.Entity;
using MVCMusicStore_06.Models;

namespace MVCMusicStore_06.DbContext
{
    public class MusicStoreDB : System.Data.Entity.DbContext
    {
        public MusicStoreDB() : base("DefaultConnection") { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; } 
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MVCMusicStore_06.Models.Order> Orders { get; set; }
    }
}