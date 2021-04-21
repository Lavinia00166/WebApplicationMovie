using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovie.Models
{
    public class Movie
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string ReleaseDate { get; set; }
    }
}
