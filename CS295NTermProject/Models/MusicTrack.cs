using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS295NTermProject.Models
{
    public class MusicTrack
    {
        public MusicTrack(string name, string genre, string fileName, List<string> moods, List<string> instruments, List<string> tags)
        {
            Name = name;
            Genre = genre;
            FileName = fileName;
            this.moods = moods;
            this.instruments = instruments;
            this.tags = tags;
        }

        private List<string> moods = new List<string>();

        private List<string> instruments = new List<string>();

        private List<string> tags = new List<string>();

        private List<Comment> comments = new List<Comment>();

        private List<Rating> ratings = new List<Rating>();

        public string Name { get; set; }

        public string Genre { get; set; }

        public string FileName { get; set; }

        public List<string> Moods { get { return moods; } }

        public List<string> Instruments { get { return instruments; } }

        public List<string> Tags { get { return tags; } }

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
