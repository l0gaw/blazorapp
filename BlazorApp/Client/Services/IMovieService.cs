using BlazorApp.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Client.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMovies();
    }
}
