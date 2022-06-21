using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homecoming.webapp.ViewModel
{
    public class CaptureDetailsHelper
    {
        [Key]
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int RoomNumber { get; set; }
        public int BookingRange { get { return (CheckOut- CheckIn).Days; } }
        public decimal Price { get; set; }
    }
}
