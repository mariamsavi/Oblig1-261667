using System.ComponentModel.DataAnnotations;

namespace Oblig1_261667.Models

{
    public class Bruker
    {
        public int Id { get; set; }

        [Required]
        public string Navn { get; set; }

        [Required]
        public string KontaktInfo { get; set; }

        [Display(Name = "Antall Spill")]
        public int AntallSpill { get; set; }
    }
}
