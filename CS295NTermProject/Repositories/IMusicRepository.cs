using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS295NTermProject.Models;

namespace CS295NTermProject.Repositories
{
    public interface IMusicRepository
    {
        List<MusicTrack> MusicTracks { get; }
        List<MusicTrack> CurrentMusicTracks { get; set; }
        string CurrentMood { get; set; }
        string CurrentInstrument { get; set; }
        string CurrentGenre { get; set; }
        List<MoodTag> MoodList { get; }
        List<InstrumentTag> InstrumentList { get; }
        List<GenreTag> GenreList { get; }
        void SaveSongToDatabase(MusicTrack musicTrack);
        void AddMusicTrack(MusicTrack musicTrack);
        MusicTrack GetMusicTrackByName(string name);
        List<MusicTrack> GetMusicTracksByMood(List<MusicTrack> tracks, string moodSelect);
        List<MusicTrack> GetMusicTracksByInstrument(List<MusicTrack> tracks, string instrumentSelect);
        List<MusicTrack> GetMusicTracksByGenre(List<MusicTrack> tracks, string genreSelect);
    }
}
