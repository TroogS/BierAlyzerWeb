﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BierAlyzerWeb.Models.Management
{
    public class ManageDrinkModel
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the drink. </summary>
        /// <value> The identifier of the drink. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Guid DrinkId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether this object is visible. </summary>
        /// <value> True if visible, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool Visible { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name. </summary>
        /// <value> The name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Ein Getränk braucht einen Namen")]
        public string Name { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public double Amount { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the percentage. </summary>
        /// <value> The percentage. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public double Percentage { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the number of usages. </summary>
        /// <value> The number of usages. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public int UsageCount { get; set; }
    }
}