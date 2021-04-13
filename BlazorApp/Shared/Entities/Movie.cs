using System;

namespace BlazorApp.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
        public string TitleBrief { get => Title?.Length > 60 ? Title.Substring(0, 60) : Title; }
    }
}
