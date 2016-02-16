using MVCMusicStore_05.Models;

namespace MVCMusicStore_05.DbContext
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist() { Name = "Al Di Meola" });
            context.Genres.Add(new Genre() { Name = "Jazz" });
            context.Albums.Add(new Album()
            {
                Artist = new Artist() { Name = "Rush" },
                Genre = new Genre() { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
        }
    }
}