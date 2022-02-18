﻿using AnimeDatabase.Domain.Model;
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

            //ExampleData
            //Source: https://myanimelist.net/anime/48583/Shingeki_no_Kyojin__The_Final_Season_Part_2
            builder.Entity<Anime>()
                .HasData(
                    new Anime { Id = 1, Title = "Shingeki no Kyojin: The Final Season Part 2" }
                );

            builder.Entity<AnimeDetails>()
                .HasData(
                    new AnimeDetails { Id = 1, Synopsis = @"Turning against his former allies and enemies alike, Eren Yeager sets a disastrous plan in motion. 
                    Under the guidance of the Beast Titan, Zeke, Eren takes extreme measures to end the ancient conflict between Marley and Eldia—but his 
                    true intentions remain a mystery. Delving deep into his family's past, Eren fights to control his own destiny. 
                    Meanwhile, the long-feuding nations of Marley and Eldia utilize both soldiers and Titans in a brutal race to eliminate the other. 
                    Reiner Braun uses his own powers in a desperate bid to hold off Eren's own militaristic force, and his fellow Eldians—children Falco 
                    Grice and Gabi Braun—struggle to survive in the unfolding chaos.Elsewhere, Eren's childhood friends Mikasa Ackerman and Armin 
                    Arlert remain imprisoned alongside Eren's former Survey Corps companions, all disturbed by Eren's monstrous transformation. 
                    Under the blind belief that Eren still secretly harbors good intentions, Mikasa and the others enter the fray in an attempt 
                    to save their friend's very soul.", AnimeId = 1 }
                );
        }
    }
}
