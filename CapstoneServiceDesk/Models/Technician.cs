using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models
{
    public class Technician
    {
        /// <summary>
        /// Technician an Admin?
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// First name of the Technician
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the Technician
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Date the technician was hired
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Pay rate for this technician
        /// </summary>
        /// <returns>Pay rate</returns>
        public int GetPayRate()
        {
            return 30 + 10 * (int)((DateTime.Now - DateAdded).TotalDays / 365);            
        }
    }
}
