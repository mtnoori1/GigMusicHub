using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigMusicHub.Models;
using GigMusicHub.ViewModels;
using Microsoft.AspNet.Identity;

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
        [HttpPost]
        public ActionResult Create(GigForViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();
            var artist = _context.Users.Single(u => u.Id == artistId);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            var gig = new Gig
            {
                Artist = artist,
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                Genre = genre,
                venue = viewModel.venue
            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}