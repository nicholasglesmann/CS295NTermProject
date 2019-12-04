using Microsoft.EntityFrameworkCore;

using CS295NTermProject.Models;

namespace CS295NTermProject.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }



        public DbSet<MusicTrack> MusicTracks { get; set; }
        public DbSet<GenreTag> GenreTags { get; set; }
        public DbSet<MoodTag> MoodTags { get; set; }
        public DbSet<InstrumentTag> InstrumentTags { get; set; }
        public DbSet<OtherTag> OtherTags { get; set; }

        public DbSet<MusicTrackMoodTag> MusicTrackMoodTags { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicTrackMoodTag>()
                 .HasKey(x => new { x.MusicTrackID, x.MoodTagID });

            modelBuilder.Entity<MusicTrackMoodTag>()
                .HasOne(x => x.MusicTrack)
                .WithMany(y => y.MusicTrackMoodTags)
                .HasForeignKey(y => y.MusicTrackID);

            modelBuilder.Entity<MusicTrackMoodTag>()
                .HasOne(x => x.MoodTag)
                .WithMany(y => y.MusicTrackMoodTags)
                .HasForeignKey(y => y.MoodTagID);

            modelBuilder.Entity<MusicTrackInstrumentTag>()
                .HasKey(x => new { x.MusicTrackID, x.InstrumentTagID });

                modelBuilder.Entity<MusicTrackInstrumentTag>()
                    .HasOne(x => x.MusicTrack)
                    .WithMany(y => y.MusicTrackInstrumentTags)
                    .HasForeignKey(y => y.MusicTrackID);

                modelBuilder.Entity<MusicTrackInstrumentTag>()
                    .HasOne(x => x.InstrumentTag)
                    .WithMany(y => y.MusicTrackInstrumentTags)
                    .HasForeignKey(y => y.InstrumentTagID);

            modelBuilder.Entity<MusicTrackOtherTag>()
                .HasKey(x => new { x.MusicTrackID, x.OtherTagID });

                modelBuilder.Entity<MusicTrackOtherTag>()
                    .HasOne(x => x.MusicTrack)
                    .WithMany(y => y.MusicTrackOtherTags)
                    .HasForeignKey(y => y.MusicTrackID);

                modelBuilder.Entity<MusicTrackOtherTag>()
                    .HasOne(x => x.OtherTag)
                    .WithMany(y => y.MusicTrackOtherTags)
                    .HasForeignKey(y => y.OtherTagID);
        }
    }
}
