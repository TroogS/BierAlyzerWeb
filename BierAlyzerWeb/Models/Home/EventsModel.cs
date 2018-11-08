﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Contracts.Model;

namespace BierAlyzerWeb.Models.Home
{
    public class EventsModel
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        /// <remarks>   Andre Beging, 03.05.2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public EventsModel()
        {
            Events = new List<Event>();
            PublicEvents = new List<Event>();
            RecentEvents = new List<Event>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the user. </summary>
        /// <value> The user. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public User User { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the events. </summary>
        /// <value> The events. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<Event> Events { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the public events. </summary>
        /// <value> The public events. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<Event> PublicEvents { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the event code. </summary>
        /// <value> The event code. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [Required]
        public string EventCode { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   List of Recently closed events. </summary>
        /// <value> List of Event objects. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<Event> RecentEvents {get; set;}
    }
}