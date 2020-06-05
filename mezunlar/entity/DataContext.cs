using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
            
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Etkinlikler> Etkinliklers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

       
    }
}