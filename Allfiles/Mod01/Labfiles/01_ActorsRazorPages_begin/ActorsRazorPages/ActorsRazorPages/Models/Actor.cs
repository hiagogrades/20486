using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorsRazorPages.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Konownfor { get; set; }
        public bool OscarWinner { get; set; }
        public string ImageName { get; set; }


    }
}
