using BlazorApp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Client.Services
{
    public class MovieServiceInMemory : IMovieService
    {
        public async Task<List<Movie>> GetMovies()
        {
            await Task.Delay(1000);
            return new List<Movie>(){
                   new Movie { Title = "Spider Man: Far from Home", 
                               ReleaseDate = new DateTime(2019, 7, 2), 
                               Poster = "https://media.movieassets.com/static/images/items/movies/posters/e0f61f917ce2e106202a101f50ce261a.jpg"},
                   new Movie { Title = "Moana", 
                               ReleaseDate = new DateTime(2020, 7, 2), 
                               Poster = "https://www.momendeavors.com/wp-content/uploads/2016/11/Moana-Poster.jpg" },
                   new Movie { Title = "Interception", 
                               ReleaseDate = new DateTime(2021, 7, 2), 
                               Poster = "https://media.movieassets.com/static/images/items/movies/posters/660ff38d36bed9a8f91f53b4e361da25.jpg"},
            };
        }
    }
}
