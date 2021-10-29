using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProjectFinal
{
    class Movie
    {
        public string title { get; set; }
        public string description { get; set; }
        public string rating { get; set; }
        public string image { get; set; }
        public static int count = 0;

        public Movie()
        {
            count++;
        }
        public Movie(string ttl, string disc, string rtng, string img)
        {
            count++;
            title = ttl;
            description = disc;
            rating = rtng;
            image = img;
        }
    }
}
