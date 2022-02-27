using AnimeDatabase.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeDatabase.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<AnimeDetails> AnimeDetails { get; set; }
        public DbSet<AnimeType> AnimeTypes { get; set; }
        public DbSet<AnimeGenre> AnimeGenres { get; set; }
        public DbSet<AnimeAnimeGenre> AnimeAnimeGenre { get; set; }


        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //one-to-one
            builder.Entity<Anime>()
                .HasOne<AnimeDetails>(x => x.AnimeDetails)
                .WithOne(x => x.Anime)
                .HasForeignKey<AnimeDetails>(x => x.AnimeId);

            //many-to-many
            builder.Entity<AnimeAnimeGenre>()
                .HasKey(x => new { x.AnimeId, x.AnimeGenreId });

            builder.Entity<AnimeAnimeGenre>()
                .HasOne<Anime>(x => x.Anime)
                .WithMany(x => x.AnimeAnimeGenres)
                .HasForeignKey(x => x.AnimeId);

            builder.Entity<AnimeAnimeGenre>()
                .HasOne<AnimeGenre>(x => x.AnimeGenre)
                .WithMany(x => x.AnimeAnimeGenres)
                .HasForeignKey(x => x.AnimeGenreId);

            //ExampleData
            //Source: https://myanimelist.net/anime/48583/Shingeki_no_Kyojin__The_Final_Season_Part_2
            builder.Entity<Anime>()
                .HasData(
                    new Anime { Id = 1, Title = "Shingeki no Kyojin: The Final Season Part 2", AnimeTypeId = 1 },
                    new Anime { Id = 2, Title = "Fullmetal Alchemist: Brotherhood", AnimeTypeId = 1 }
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
                    to save their friend's very soul.", AnimeId = 1 },
                    new AnimeDetails { Id = 2, Synopsis = @"After a horrific alchemy experiment goes wrong in the Elric household, brothers Edward and 
                    Alphonse are left in a catastrophic new reality. Ignoring the alchemical principle banning human transmutation, the boys attempted 
                    to bring their recently deceased mother back to life. Instead, they suffered brutal personal loss: Alphonse's body disintegrated while 
                    Edward lost a leg and then sacrificed an arm to keep Alphonse's soul in the physical realm by binding it to a hulking suit of armor.", AnimeId = 2 }
                );

            builder.Entity<AnimeType>()
                .HasData(
                    new AnimeType { Id = 1, Name = "tv" },
                    new AnimeType { Id = 2, Name = "movie" }
                );

            builder.Entity<AnimeGenre>()
                .HasData(
                    new AnimeGenre { Id = 1, Name = "Action"},
                    new AnimeGenre { Id = 2, Name = "Drama"},
                    new AnimeGenre { Id = 3, Name = "Fantasy"},
                    new AnimeGenre { Id = 4, Name = "Mystery"},
                    new AnimeGenre { Id = 5, Name = "Comedy"}
                );

            builder.Entity<AnimeAnimeGenre>()
                .HasData(
                    new AnimeAnimeGenre { AnimeId = 1, AnimeGenreId = 1},
                    new AnimeAnimeGenre { AnimeId = 1, AnimeGenreId = 2},
                    new AnimeAnimeGenre { AnimeId = 1, AnimeGenreId = 3},
                    new AnimeAnimeGenre { AnimeId = 1, AnimeGenreId = 4},
                    new AnimeAnimeGenre { AnimeId = 2, AnimeGenreId = 1},
                    new AnimeAnimeGenre { AnimeId = 2, AnimeGenreId = 2},
                    new AnimeAnimeGenre { AnimeId = 2, AnimeGenreId = 3},
                    new AnimeAnimeGenre { AnimeId = 2, AnimeGenreId = 5}
                );
        }
    }
}