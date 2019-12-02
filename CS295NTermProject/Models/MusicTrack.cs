using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class MusicTrack
    {
        [Key]
        public int MusicTrackID { get; set; }

        public MusicTrack(string name, GenreTag genre, string fileName, List<ITag> moods, List<ITag> instruments, List<ITag> tags)
        {
            Name = name;
            Genre = genre;
            FileName = fileName;
            this.moods = moods;
            this.instruments = instruments;
            this.tags = tags;
        }

        private List<ITag> moods = new List<ITag>();

        private List<ITag> instruments = new List<ITag>();

        private List<ITag> tags = new List<ITag>();

        private List<Comment> comments = new List<Comment>();

        private List<Rating> ratings = new List<Rating>();

        public string Name { get; set; }

        public GenreTag Genre { get; set; }

        public string FileName { get; set; }

        public List<ITag> Moods { get { return moods; } }

        public List<ITag> Instruments { get { return instruments; } }

        public List<ITag> Tags { get { return tags; } }

        public List<Comment> Comments { get { return comments; } }

        public List<Rating> Ratings { get { return ratings; } }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void AddRating(Rating rating)
        {
            ratings.Add(rating);
        }
    }
}
