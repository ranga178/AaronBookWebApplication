using System.ComponentModel.DataAnnotations;

namespace AaronBookWebApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


        //child reference
        public List<Author>? Authors { get; set; }
    }
}
