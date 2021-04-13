using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
