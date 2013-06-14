using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;

namespace RottenMovies.Web.Models
{
    [DataContract]
    public class SearchMoviesResponse
    {
        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "movies")]
        public IEnumerable<Movie> Movies { get; set; } 
    }
}