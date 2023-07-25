using System.ComponentModel.DataAnnotations;

namespace AaronBookWebApplication.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public DateTime Published { get; set; }

        public Category? Category {get; set; }
    }
}
