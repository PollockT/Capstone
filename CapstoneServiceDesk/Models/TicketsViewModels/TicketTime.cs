using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models.TicketsViewModels
{
    /// <summary>
    /// Relates time and ticket information.
    /// </summary>
    public class TicketTime
    {
        /// <summary>
        /// The title of the ticket.
        /// </summary>
        public string TicketTitle { get; set; }

        /// <summary>
        /// The id of the ticket.
        /// </summary>
        public Guid TicketId { get; set; }

        /// <summary>
        /// The start time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end time.
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
