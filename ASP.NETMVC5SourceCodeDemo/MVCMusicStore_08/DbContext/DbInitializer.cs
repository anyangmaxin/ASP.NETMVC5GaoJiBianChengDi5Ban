using System;
using MVCMusicStore_08.Models;

namespace MVCMusicStore_08.DbContext
{
    public class DbInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            for (int i = 0; i < 10; i++)
            {

                context.Albums.Add(new Album()
                {
                    Artist = new Artist() { Name = "Rush" + new Random().Next(100) },
                    Genre = new Genre() { Name = "Rock" + new Random().Next(100) },
                    Price = (decimal)(i + 1),
                    Title = "Caravan" + new Random().Next(100)
                });
            }


        }
    }
}