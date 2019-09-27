using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImgUrl { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Tag { get; set; }
        public string Actor { get; set; }
        public string Cont { get; set; }
    }
}
