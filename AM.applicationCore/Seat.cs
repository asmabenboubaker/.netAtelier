using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        [MinLength(1, ErrorMessage = "The Name field must have at least 1 character.")]
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        [Range(0, 20, ErrorMessage = "The Size field must be between 0 and 20.")]
       
        
        public int Size { get; set; }
        public virtual Plane PlaneFK { get; set; }
        public virtual List<Reservation> reservation { get; set; }
        public int SectionFK { get; set; }
        public virtual Section Section { get; set; }
    }
}
