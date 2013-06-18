using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RottenMovies.Web.Models
{
    public class Movie
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "synopsis")]
        public string Synopsis { get; set; }
    }
}