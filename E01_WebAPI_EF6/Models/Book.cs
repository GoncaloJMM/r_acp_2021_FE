using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Book
    {
        public int Id { get; set; }         //PK
        public int AuthorId { get; set; }   // Foreign Key
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        
        
        // Navigation property
        public Author Author { get; set; }
    }
}