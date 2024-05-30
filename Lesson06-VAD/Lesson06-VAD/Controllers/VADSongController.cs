using Lesson06_VAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson06_VAD.Controllers
{
    public class VADSongController : Controller
    {
        // GET: VADSong
        public static List<VADSong> VADSongs = new List<VADSong>()
        {
            new VADSong{ ID = 221090017,VADTitle = "Vũ Anh Dương", VADAuthor = "K22CNT2" , VADArtist = "Dương", VADYearRelease = 2020},
            new VADSong{ ID = 2 ,VADTitle = "Nguyễn Quang Q", VADAuthor = "K22CNT2" , VADArtist = "Q", VADYearRelease = 2020},
        };
        // GET: TDTDSong
        public ActionResult VADIndex()
        {
            return View(VADSongs);
        }
        public ActionResult VADCreate()
        {
            var VADsong = new VADSong();
            return View(VADsong);
        }
        [HttpPost]
        public ActionResult VADCreate(VADSong vadSong)
        {
            if (!ModelState.IsValid) // lỗi
            {
                return View(vadSong);
            }
            // du lieu dung 
            VADSongs.Add(vadSong);
            return RedirectToAction("VADIndex");
        }
    }
}
