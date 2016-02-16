using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCMusicStore_11.Models;

namespace MVCMusicStore_11.DbContext
{
    public class DataContext:System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}