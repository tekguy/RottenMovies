using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;
using RottenMovies.Common;
using RottenMovies.Web.Models;

namespace RottenMovies.Web.Controllers
{
    public class RottenTomatoeController : BaseController
    {
        [HttpPost]
        public JsonResult SearchMovies(string title)
        {
            // perform search
            var movies = SearchMoviesOnRotten(title);

            return Json(movies);

        }

        private IEnumerable<Movie> SearchMoviesOnRotten(string title)
        {
            IEnumerable<Movie> movies = new List<Movie>();
            try
            {
                string domainUrl = "http://api.rottentomatoes.com";
                string resourceUrl = "api/public/v1.0/movies.json";

                // make a call via restsharp
                var client = new RestClient(domainUrl);
                var request = new RestRequest(resourceUrl);

                request.AddParameter("apikey", AppSetting.RottenAPIToken);
                request.AddParameter("q", title);

                var response = client.Execute(request);
                var content = response.Content; // raw content as string

                var searchResults = JsonConvert.DeserializeObject<SearchMoviesResponse>(content);
                movies = searchResults.Movies;


            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

            return movies;
        }
    }
}
