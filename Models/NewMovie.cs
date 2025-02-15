using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Mission06_Hair.Models
{
    public class NewMovie
    {
        //MovieID is Primary key
        [Key]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
