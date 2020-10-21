using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models.TicketsViewModels
{
    public class TechnicianTime
    {
        public Technician Technician { get; set; }
        public TechnicianTicketTime Time { get; set; }
    }
}
