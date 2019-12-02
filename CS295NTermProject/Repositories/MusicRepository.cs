using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS295NTermProject.Models;

namespace CS295NTermProject.Repositories
{
    public class MusicRepository : IMusicRepository
    {
        private static List<MusicTrack> musicTracks = new List<MusicTrack>();

        public List<MusicTrack> MusicTracks { get { return musicTracks; } }

        private static List<MusicTrack> currentMusicTracks = new List<MusicTrack>();

        public List<MusicTrack> CurrentMusicTracks { get { return currentMusicTracks; } set { currentMusicTracks = value; } }

        private static List<string> moodList = new List<string>();

        public List<string> MoodList { get { return moodList; } }

        private static List<string> instrumentList = new List<string>();

        public List<string> InstrumentList { get { return instrumentList; } }

        private static List<string> genreList = new List<string>();

        public List<string> GenreList { get { return genreList; } }

        private static string currentMood = "";

        public string CurrentMood { get { return currentMood; } set { currentMood = value; } }

        private static string currentInstrument = "";

        public string CurrentInstrument { get { return currentInstrument; } set { currentInstrument = value; } }

        private static string currentGenre = "";

        public string CurrentGenre { get { return currentGenre; } set { currentGenre = value; } }

        public MusicRepository()
        {
            if (MusicTracks.Count == 0)
            {
                //AddSeedData();
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

        public List<MusicTrack> GetMusicTracksByMood(List<MusicTrack> tracks, string moodSelect)
        {
            List<MusicTrack> musicTracksByMood = (List<MusicTrack>)tracks.Where(m => m.Moods.Any(mood => mood.Tag == moodSelect)).ToList();
            return musicTracksByMood;
        }

        public List<MusicTrack> GetMusicTracksByInstrument(List<MusicTrack> tracks, string instrumentSelect)
        {
            List<MusicTrack> musicTracksByInstrument = (List<MusicTrack>)tracks.Where(m => m.Instruments.Any(instrument => instrument.Tag == instrumentSelect)).ToList();
            return musicTracksByInstrument;
        }

        public List<MusicTrack> GetMusicTracksByGenre(List<MusicTrack> tracks, string genreSelect)
        {
            List<MusicTrack> musicTrackByGenre = (List<MusicTrack>)tracks.Where(m => m.Genre.Tag == genreSelect).ToList();
            return musicTrackByGenre;
        }
    }
}
