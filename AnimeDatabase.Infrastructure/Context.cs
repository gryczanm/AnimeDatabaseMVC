using AnimeDatabase.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeDatabase.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<AnimeDetails> AnimeDetails { get; set; }
        // public DbSet<AnimeTag> AnimesTags { get; set; }
        // public DbSet<Anime_AnimeTag> Anime_AnimeTag { get; set; }
        // public DbSet<AnimeType> AnimeTypes { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Anime>()
                .HasOne<AnimeDetails>(x => x.Details)
                .WithOne(x => x.Anime)
                .HasForeignKey<AnimeDetails>(x => x.AnimeId);
            

            // //relacja one-to-one Anime i AnimeDetails
            // builder.Entity<Anime>()
            //     .HasOne<AnimeDetails>(x => x.AnimeDetails)
            //     .WithOne(x => x.Anime)
            //     .HasForeignKey<AnimeDetails>(x => x.AnimeId);
            //
            // //relacja one-to-many Anime i Type
            // builder.Entity<Anime>()
            //     .HasOne(x => x.Type)
            //     .WithMany(x => x.Animes)
            //     .HasForeignKey(x => x.TypeId);
            //
            // //relacja many-to-many Anime i Tag łącznikiem jest AnimeTag
            // builder.Entity<Anime_AnimeTag>()
            //     .HasKey(x => new { x.AnimeId, x.TagId });
            //
            // builder.Entity<Anime_AnimeTag>()
            //     .HasOne<Anime>(x => x.Anime)
            //     .WithMany(x => x.Anime_AnimeTags)
            //     .HasForeignKey(x => x.AnimeId);
            //
            // builder.Entity<Anime_AnimeTag>()
            //     .HasOne<AnimeTag>(x => x.Tag)
            //     .WithMany(x => x.Anime_AnimeTags)
            //     .HasForeignKey(x => x.TagId);
            //
            //
            // //ExampleData
            // builder.Entity<AnimeType>()
            //     .HasData(
            //         new AnimeType { Id = 1, Name = "TV" },
            //         new AnimeType { Id = 2, Name = "Movie"}
            //     );
        }
    }
}
