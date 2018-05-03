﻿using System.Collections.Generic;
using Contracts.Model;

namespace BierAlyzerWeb.Models.Home
{
    public class EventModel
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        /// <remarks>   Andre Beging, 03.05.2018. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public EventModel()
        {
            Drinks = new List<Drink>();
            EventUsers = new List<EventUserModel>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the event. </summary>
        /// <value> The event. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Event Event { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the drinks. </summary>
        /// <value> The drinks. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<Drink> Drinks { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the event users. </summary>
        /// <value> The event users. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<EventUserModel> EventUsers { get; set; }
    }
}