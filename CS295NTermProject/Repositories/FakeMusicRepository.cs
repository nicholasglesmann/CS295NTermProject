using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS295NTermProject.Models;

namespace CS295NTermProject.Repositories
{
    public class FakeMusicRepository : IMusicRepository
    {
        private static List<MusicTrack> musicTracks = new List<MusicTrack>();

        public List<MusicTrack> MusicTracks { get { return musicTracks; } }

        public FakeMusicRepository()
        {
            if(MusicTracks.Count == 0)
            {
                AddSeedData();
            }
        }

        public void AddMusicTrack(MusicTrack musicTrack)
        {
            musicTracks.Add(musicTrack);
        }

        public MusicTrack GetMusicTrackByName(string name)
        {
            MusicTrack musicTrack = musicTracks.Find(m => m.Name == name);
            return musicTrack;
        }

        public void AddSeedData()
        {
            List<string> moods = new List<string>{ "beautiful", "calm", "emotional", "gentle", "hopeful", "inspirational", "optimistic", "peaceful", "relaxing", "romantic", "sentimental", "uplifting" };
            List<string> instruments = new List<string>{ "cello", "piano", "violin" };
            List<string> tags = new List<string>{ "beautiful", "calm", "emotional", "gentle", "hopeful", "inspirational", "optimistic", "peaceful", "relaxing", "romantic", "sentimental", "uplifting" };
            MusicTrack song = new MusicTrack("Beautiful Cinematic Piano", "Cinematic", "Beautiful-Cinematic-Piano.mp3", moods, instruments, tags);
            AddMusicTrack(song);
        }
    }
}
