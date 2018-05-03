﻿using System.Collections.Generic;
using Contracts.Model;

namespace BierAlyzerWeb.Models.Management
{
    public class ManageUsersModel
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        /// <remarks>   Andre Beging, 03.05.2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public ManageUsersModel()
        {
            Users = new List<User>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the users. </summary>
        /// <value> The users. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<User> Users { get; set; }
    }
}