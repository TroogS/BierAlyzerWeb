﻿using System.Collections.Generic;
using BierAlyzer.EntityModel;

namespace BierAlyzer.Web.Models.Home
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
            DrinkUsage = new Dictionary<string, int>();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the drink usage. </summary>
        ///
        /// <value> The drink usage. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Dictionary<string, int> DrinkUsage { get; set; }
    }
}