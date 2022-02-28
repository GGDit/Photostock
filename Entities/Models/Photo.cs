using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Photo
    {
        [Column("PhotoId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Photo name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Link to photo is a required field.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Photo size is a required field.")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Photo data creation is a required field.")]
        public DateTime PhotoCreationData { get; set; }

        [Required(ErrorMessage = "Photo price is a required field.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Photo purchases number is a required field.")]
        public int PurchasesNumber { get; set; }

        [Required(ErrorMessage = "Photo rating is a required field.")]
        public int Rating { get; set; }


        [ForeignKey(nameof(Author))]
        [Required(ErrorMessage = "Author of this photo is a required field.")]
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
