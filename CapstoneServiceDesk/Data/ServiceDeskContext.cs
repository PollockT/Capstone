using CapstoneServiceDesk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Data.Common;


namespace CapstoneServiceDesk.Data
{
    public class ServiceDeskContext : Technician
    {
        public List<Employee> Employee { get; set; }

        public List<Ticket> Ticket { get; set; }

        public List<TechnicianTicketTime> TechnicianTicketTime { get; set; }


        public ServiceDeskContext(DbContextOptions<ServiceDeskContext> options) : base(options)
        {

        }
    }
}
