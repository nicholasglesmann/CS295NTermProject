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
        void AddMusicTrack(MusicTrack musicTrack);
        MusicTrack GetMusicTrackByName(string name);
    }
}
