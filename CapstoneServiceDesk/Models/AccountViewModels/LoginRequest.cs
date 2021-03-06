﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneServiceDesk.Models.AccountViewModels
{
    public class LoginRequest
    {
        /// <summary>
        /// Gets User Name
        /// </summary>        
        public string Username { get; set; }

        /// <summary>
        /// Gets User Password
        /// </summary>               
        public string Password { get; set; }

        /// <summary>
        /// Ability to allow user's info to be stored
        /// on login
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
