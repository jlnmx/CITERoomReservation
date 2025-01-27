using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITERoomReservationForm
{
    public class Reservation
    {
        public string Room { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Professor { get; set; }
    }
}
