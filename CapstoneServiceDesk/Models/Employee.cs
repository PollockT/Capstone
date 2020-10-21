using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models
{
    public class Employee
    {
        /// <summary>
        /// Unique Id for employee
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// First Name of Employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of Employee
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Phone number of Employee
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email Address, primary contact of Employee
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Department of requesting Employee
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Building Addressing of Employee
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Date that the Employee was ADDED TO THE SYSTEM! NOT TICKET RELATED!
        /// </summary>
        public DateTime DateAdded { get; set; }
    }
}
