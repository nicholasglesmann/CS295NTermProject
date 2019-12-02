using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
