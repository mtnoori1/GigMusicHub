using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigMusicHub.Models
{
    public class Gig 
    {
        public int Id { get; set; }
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }
        public string venue { get; set; }
        public Genre Genre { get; set; }


    }
   

}