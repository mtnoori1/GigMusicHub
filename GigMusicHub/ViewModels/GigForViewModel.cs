using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigMusicHub.Models;

namespace GigMusicHub.ViewModels
{
    public class GigForViewModel
    {
        public string venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}