using AnimeDatabase.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Type = AnimeDatabase.Domain.Model.Type;

namespace AnimeDatabase.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<AnimeDetails> AnimeDetails { get; set; }
        public DbSet<AnimeTag> AnimesTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //relacja one-to-one Anime i AnimeDetails
            builder.Entity<Anime>()
                .HasOne(a => a.AnimeDetails)
                .WithOne(a => a.Anime)
                .HasForeignKey<AnimeDetails>(a => a.AnimeRef);

            //builder.Entity<Anime>()
            //    .HasOne(a => a.Type)
            //    .WithMany(a => a.animes);

            //relacja many-to-many Anime i Tag łącznikiem jest AnimeTag
            builder.Entity<AnimeTag>()
                .HasKey(a => new { a.AnimeId, a.TagId });

            builder.Entity<AnimeTag>()
                .HasOne<Anime>(a => a.Anime)
                .WithMany(a => a.animeTags)
                .HasForeignKey(a => a.AnimeId);

            builder.Entity<AnimeTag>()
                .HasOne<Tag>(a => a.Tag)
                .WithMany(a => a.animeTags)
                .HasForeignKey(a => a.TagId);
        }
    }
}
