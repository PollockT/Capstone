using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models
{
    public class TechnicianTicketTime
    {
        public Guid Id { get; set; }

        public string TechnicianId { get; set; }

        public Guid TicketId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
