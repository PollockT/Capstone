using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CapstoneServiceDesk.Data;
using CapstoneServiceDesk.Models;
using CapstoneServiceDesk.Pages;
using CapstoneServiceDesk.Models.ReportsViewModels;

namespace CapstoneServiceDesk.Controllers
{
    public class ReportController : Controller
    {
        private ServiceDeskContext _context;

        /// <summary>
        /// Initializes this controller
        /// </summary>
        /// <param name="context">context of the technician</param>
        public ReportController(ServiceDeskContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the report view
        /// </summary>
        /// <returns>The report view</returns>
        [HttpGet]
        public Task<IActionResult> All()
        {
            // var timeSpan = new TimeSpan(hours: 24, minutes: 0, seconds: 0);
            // var end = DateTime.Now;
            // var start = end - timeSpan;

            // var openEvents = (await _context.Tickets.Where(ticket => ticket.DateAdded > start || (ticket.DateAdded <= start && (ticket.DateClosed > start || ticket.Open))).Select(ticket => ticket.DateAdded < start ? start : ticket.DateAdded).ToListAsync()).Select(time => (time, true));
            // var closeEvents = (await _context.Tickets.Where(ticket => ticket.DateClosed > start).Select(ticket => ticket.DateClosed).ToListAsync()).Select(time => (time, false));

            // var events = new List<IEnumerable<(DateTime, bool)>> { openEvents, closeEvents }.SelectMany(ticket => ticket); OrderBy<IQueryable<(DateTime, bool)>, bool>((time, open) => true);

            var details = new ReportDetails
            {
                AverageQueueLength =  _context.Ticket.Where(ticket => ticket.Status),
                AverageWait = new TimeSpan(0, 0, 0),
                EmptyQueuePercentage = 0,
                TicketsNotAddressedSameDay = 15,
                TechnicianIdleHours =  _context.UserName.GroupJoin(_context.TechnicianTicketTime, technician => technician.UserName, time => time.TechnicianId, (technician, times) => new { Technician = technician, Time = 8 }).ToAsyncEnumerable().Select(techTime => (techTime.Technician, techTime.Time)).ToList()
            };
            return View(details);
        }
    }
}
