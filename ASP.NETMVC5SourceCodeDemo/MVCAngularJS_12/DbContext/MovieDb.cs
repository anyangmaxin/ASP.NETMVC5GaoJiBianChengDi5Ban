using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCAngularJS_12.Models;

namespace MVCAngularJS_12.DbContext
{
    public class MovieDb:System.Data.Entity.DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}