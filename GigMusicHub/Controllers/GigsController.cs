using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigMusicHub.Models;
using GigMusicHub.ViewModels;

namespace GigMusicHub.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: Gigs
        public ActionResult Create()
        {
            var ViewModel = new GigForViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(ViewModel);
        }
    }
}