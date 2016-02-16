using System.Data.Entity;
using MVCMusicStore_04.Models;

namespace MVCMusicStore_04.DbContext
{
    public class MusicStoreDB:System.Data.Entity.DbContext
    {
        public MusicStoreDB() : base("DefaultConnection")
        {
            
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; } 
        public DbSet<Genre> Genres { get; set; } 
    }
}