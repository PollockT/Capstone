using CapstoneServiceDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Data
{
    public class ServiceDeskContext
    {
        public List<Employee> Employee { get; set; }

        public List<Ticket> Ticket { get; set; }

        public List<TechnicianTicketTime> TechnicianTicketTime { get; set; }


        public ServiceDeskContext(DbContextOptions<ServiceDeskContext> options) : base(options)
        {

        }
    }
}
