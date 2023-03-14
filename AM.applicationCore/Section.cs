using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        [MinLength(1, ErrorMessage = "The Name field must have at least 1 character.")]
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
