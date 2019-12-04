using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS295NTermProject.Models;
using CS295NTermProject.Repositories;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace CS295NTermProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        IMusicRepository musicRepo;

        public HomeController(IMusicRepository music, IHostingEnvironment hostingEnvironment)
        {
            musicRepo = music;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Music()
        {
            // get the list of moods and store it in viewdata for music view
            ViewData["allMoods"] = musicRepo.MoodList;
            ViewData["allInstruments"] = musicRepo.InstrumentList;
            ViewData["allGenres"] = musicRepo.GenreList;

            List<MusicTrack> currentMusicTracks = musicRepo.MusicTracks;

            if(musicRepo.CurrentMood != "")
            {
                currentMusicTracks = musicRepo.GetMusicTracksByMood(currentMusicTracks, musicRepo.CurrentMood);
            }

            if(musicRepo.CurrentInstrument != "")
            {
                currentMusicTracks = musicRepo.GetMusicTracksByInstrument(currentMusicTracks, musicRepo.CurrentInstrument);
            }

            if(musicRepo.CurrentGenre != "")
            {
                currentMusicTracks = musicRepo.GetMusicTracksByGenre(currentMusicTracks, musicRepo.CurrentGenre);
            }

            ViewBag.currentMood = musicRepo.CurrentMood;

            ViewBag.currentInstrument = musicRepo.CurrentInstrument;

            ViewBag.currentGenre = musicRepo.CurrentGenre;

            return View(currentMusicTracks);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AddSong()
        {
            // get the list of moods and store it in viewdata for music view
            ViewData["allMoods"] = musicRepo.MoodList;
            ViewData["allInstruments"] = musicRepo.InstrumentList;
            ViewData["allGenres"] = musicRepo.GenreList;

            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddSong(IFormCollection formCollection, string songName, string fileName)
        {
            var collection = formCollection;

            GenreTag genreTag = musicRepo.GetGenreTagFromDataBase(collection["genre"]);

            MusicTrack song = new MusicTrack();
            song.Name = songName;
            song.Genre = genreTag;
            song.FileName = fileName;



            List<MoodTag> moodTags = new List<MoodTag>();
            for(int i = 0; i <= musicRepo.MoodList.Count; i++)
            {
                string mood = "mood" + i.ToString();
                string value = collection[mood];
                if (value != null)
                {
                    MoodTag moodTag = musicRepo.GetMoodTagFromDatabase(value);
                    song.Moods.Add(moodTag);

                    var m = new MusicTrackMoodTag();
                    m.MusicTrack = song;
                    m.MoodTag = moodTag;
                    song.MusicTrackMoodTags.Add(m);
                }

                string instrument = "instrument" + i.ToString();
                value = collection[instrument];
                if (value != null)
                {
                    InstrumentTag instrumentTag = musicRepo.GetInstrumentTagFromDatabase(value);
                    song.Instruments.Add(instrumentTag);

                    var m = new MusicTrackInstrumentTag();
                    m.MusicTrack = song;
                    m.InstrumentTag = instrumentTag;
                    song.MusicTrackInstrumentTags.Add(m);
                }
            }

            musicRepo.MusicTracks.Add(song);

            musicRepo.SaveSongToDatabase(song);

            return RedirectToAction("Music");
        }

        public RedirectToActionResult MoodSelected(string id)
        {
            musicRepo.CurrentMood = id;
            return RedirectToAction("Music");
        }

        public RedirectToActionResult InstrumentSelected(string id)
        {
            musicRepo.CurrentInstrument = id;
            return RedirectToAction("Music");
        }

        public RedirectToActionResult GenreSelected(string id)
        {
            musicRepo.CurrentGenre = id;
            return RedirectToAction("Music");
        }

        public RedirectToActionResult ClearFilters()
        {
            musicRepo.CurrentMood = "";
            musicRepo.CurrentInstrument = "";
            musicRepo.CurrentGenre = "";
            return RedirectToAction("Music");
        }

        [HttpPost]
        public RedirectToActionResult ContactUs(string name, string messageTitle, string messageBody)
        {
            // create a new message object
            Message message = new Message();

            // get the DateTime that the form was submitted and put it into the new message object
            DateTime date = DateTime.Now;
            message.Date = date;

            // put all the form field values into the new message object
            message.Name = name;
            message.MessageTitle = messageTitle;
            message.MessageBody = messageBody;

            // store the name in the ViewBag
            ViewBag.name = name;

            // TODO: store the message in a database

            return RedirectToAction("ContactUsResponse");
        }

        public IActionResult ContactUsResponse()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public PhysicalFileResult Download(string fileName)
        {
            return GetFile(fileName);
        }

        [HttpPost]
        public FileResult Download2(string fileName)
        {
            return GetFile(fileName);
        }

        public PhysicalFileResult GetFile(string fileName)
        {

            string filePath = _hostingEnvironment.WebRootPath + "\\files\\musictracks\\" + fileName;


            return PhysicalFile(filePath, MimeTypes.GetMimeType(filePath), Path.GetFileName(filePath));
        }
    }
}
