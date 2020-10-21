using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models.TicketsViewModels
{
    public class TicketDetails
    {

        /// <summary>
        /// grabs Ticket Model
        /// </summary>
        /// <returns>the ticket</returns>
        public Ticket Ticket { get; set; }
        
        /// <summary>
        /// grabs Employee model
        /// </summary>
        /// <returns>the employee</returns>
        public Employee Employee { get; set; }

        /// <summary>
        /// List of tech time associated with ticket
        /// </summary>
        /// <returns>list of tech times</returns>
        public List<TechnicianTime> Times { get; set; }
    }
}
