using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Author
    {
        [Column("AuthorId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Author name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author nickname is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Author age is a required field.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Author data creation is a required field.")]
        public DateTime AuthorCreationData { get; set; }

        [Required(ErrorMessage = "Author rating is a required field.")]
        public int Rating { get; set; }


        public ICollection<Text> Texts { get; set; } 
        public ICollection<Photo> Photos { get; set; }
    }
}
