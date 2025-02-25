using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mission06_Hair.Models
{
    public class NewMovie
    {
        //MovieID is Primary key
        [Key]
        public int MovieID { get; set; }
        [ForeignKey("CategoryId")]
        [Required(ErrorMessage = "Sorry, you need to select a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Sorry, you need to input a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Sorry, you need to input a valid year")]

        [Range(1888, int.MaxValue, ErrorMessage = "Year must be greater than or equal to 1888")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string?   Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
