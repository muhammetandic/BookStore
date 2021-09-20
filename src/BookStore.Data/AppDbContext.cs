using BookStore.Data.FluentMappings;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace BookStore.Data
{
    public class AppDbContext : DbContext
    {
        private readonly bool _created;

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PaperType> PaperTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            if(!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(BookMapping).Assembly);  
            //builder.ApplyConfigurationsFromAssembly(typeof(CategoryMapping).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(CoverTypeMapping).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(FormatMapping).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(LanguageMapping).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(PaperTypeMapping).Assembly);
            //builder.ApplyConfigurationsFromAssembly(typeof(PublisherMapping).Assembly);
            
            //base.OnModelCreating(builder);
        }
    }
}
