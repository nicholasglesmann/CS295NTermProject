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

        public FakeMusicRepository()
        {
            if (MusicTracks.Count == 0)
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

        public List<MusicTrack> GetMusicTracksByMood(List<MusicTrack> tracks, string moodSelect)
        {
            List<MusicTrack> musicTracksByMood = (List<MusicTrack>) tracks.Where(m => m.Moods.Any(mood => mood.Tag == moodSelect)).ToList();
            return musicTracksByMood;
        }

        public List<MusicTrack> GetMusicTracksByInstrument(List<MusicTrack> tracks, string instrumentSelect)
        {
            List<MusicTrack> musicTracksByInstrument = (List<MusicTrack>) tracks.Where(m => m.Instruments.Any(instrument => instrument.Tag == instrumentSelect)).ToList();
            return musicTracksByInstrument;
        }

        public List<MusicTrack> GetMusicTracksByGenre(List<MusicTrack> tracks, string genreSelect)
        {
            List<MusicTrack> musicTrackByGenre = (List<MusicTrack>)tracks.Where(m => m.Genre.Tag == genreSelect).ToList();
            return musicTrackByGenre;
        }

        public void AddSeedData()
        {
            List<string> allMoods = new List<string>{ "beautiful", "dark", "dramatic", "emotional", "energetic", "epic", "fun", "gentle", "happy", "hopeful", "inspirational", "joyful", "light", "motivational", "optimistic", "peaceful", "powerful", "relaxing", "romantic", "sad", "sentimental", "suspenseful", "upbeat", "uplifting" };
            moodList.AddRange(allMoods);

            List<string> allInstruments = new List<string> { "acoustic guitar", "bass", "cello", "percussion", "piano", "strings", "synth", "violin" };
            instrumentList.AddRange(allInstruments);

            List<string> allGenres = new List<string> { "Acoustic", "Ambient", "Cinematic", "Corporate", "Electronica", "Holiday", "Other", "Pop", "Rock" };
            genreList.AddRange(allGenres);

            GenreTag cinematic = new GenreTag("Cinematic");
            GenreTag acoustic = new GenreTag("Acoustic");

            MoodTag beautiful = new MoodTag("beautiful");
            MoodTag calm = new MoodTag("calm");
            MoodTag cool = new MoodTag("cool");
            MoodTag dark = new MoodTag("dark");
            MoodTag dramatic = new MoodTag("dramatic");
            MoodTag emotional = new MoodTag("emotional");
            MoodTag energetic = new MoodTag("energetic");
            MoodTag epic = new MoodTag("epic");
            MoodTag fun = new MoodTag("fun");
            MoodTag gentle = new MoodTag("gentle");
            MoodTag happy = new MoodTag("happy");
            MoodTag hopeful = new MoodTag("hopeful");
            MoodTag inspirational = new MoodTag("inspirational");
            MoodTag joyful = new MoodTag("joyful");
            MoodTag laidBack = new MoodTag("laid back");
            MoodTag light = new MoodTag("light");
            MoodTag motivational = new MoodTag("motivational");
            MoodTag optimistic = new MoodTag("optimistic");
            MoodTag peaceful = new MoodTag("peaceful");
            MoodTag positive = new MoodTag("positive");
            MoodTag powerful = new MoodTag("powerful");
            MoodTag relaxing = new MoodTag("relaxing");
            MoodTag romantic = new MoodTag("romantic");
            MoodTag sentimental = new MoodTag("sentimental");
            MoodTag suspenseful = new MoodTag("suspenseful");
            MoodTag upbeat = new MoodTag("upbeat");
            MoodTag uplifting = new MoodTag("uplifting");

            InstrumentTag acousticGuitar = new InstrumentTag("acoustic guitar");
            InstrumentTag bass = new InstrumentTag("bass");
            InstrumentTag cello = new InstrumentTag("cello");
            InstrumentTag percussion = new InstrumentTag("percussion");
            InstrumentTag piano = new InstrumentTag("piano");
            InstrumentTag strings = new InstrumentTag("strings");
            InstrumentTag synth = new InstrumentTag("synth");
            InstrumentTag violin = new InstrumentTag("violin");

            OtherTag beach = new OtherTag("beach");
            OtherTag beauty = new OtherTag("beauty");
            OtherTag brave = new OtherTag("brave");


            List<ITag> moods = new List<ITag>{ beautiful, calm, emotional, gentle, hopeful, inspirational, optimistic, peaceful, relaxing, romantic, sentimental, uplifting};
            List<ITag> instruments = new List<ITag>{ cello, piano, violin };
            List<ITag> tags = new List<ITag> { beauty };
            tags.Add(cinematic);
            tags.AddRange(moods);
            tags.AddRange(instruments);
            MusicTrack song = new MusicTrack("Beautiful Cinematic Piano", cinematic, "Beautiful-Cinematic-Piano.mp3", moods, instruments, tags);
            AddMusicTrack(song);

            moods = new List<ITag> { cool, dark, dramatic, energetic, epic, inspirational, motivational, powerful, suspenseful, upbeat };
            instruments = new List<ITag> { cello, percussion, violin, strings };
            tags = new List<ITag> { beauty, brave };
            tags.Add(cinematic);
            tags.AddRange(moods);
            tags.AddRange(instruments);
            song = new MusicTrack("Epic Cinematic Trailer", cinematic, "Epic-Cinematic-Trailer.mp3", moods, instruments, tags);
            AddMusicTrack(song);

            instruments = new List<ITag> { percussion };
            tags = new List<ITag> { brave };
            tags.Add(cinematic);
            tags.AddRange(moods);
            tags.AddRange(instruments);
            song = new MusicTrack("Epic Upbeat Cinematic Percussion", cinematic, "Epic-Upbeat-Cinematic-Percussion.mp3", moods, instruments, tags);
            AddMusicTrack(song);

            moods = new List<ITag> { calm, energetic, fun, happy, hopeful, inspirational, joyful, laidBack, light, optimistic, positive, upbeat, uplifting };
            instruments = new List<ITag> { acousticGuitar, bass, piano, percussion, synth };
            tags = new List<ITag> { beach };
            tags.Add(acoustic);
            tags.AddRange(moods);
            tags.AddRange(instruments);
            song = new MusicTrack("Happy Acoustic Summer Whistle", acoustic, "Happy-Acoustic-Summer-Whistle.mp3", moods, instruments, tags);
            AddMusicTrack(song);
        }
    }
}
