using System;
using System.Collections.Generic;
using System.Linq;
using BierAlyzerWeb.Helper;
using Microsoft.AspNetCore.Html;

namespace BierAlyzer.Web.Helper
{
    public static class WebHelper
    {
        #region BuildTypeaheadOrigins

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        ///     Builds a javascript compatible list of both known origins from <see cref="SharedProperties.KnownOrigins" />
        ///     and origins from the database
        /// </summary>
        /// <remarks>   Andre Beging, 03.05.2018. </remarks>
        /// <returns>   A HtmlString. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public static HtmlString BuildTypeaheadOrigins()
        {
            var outputOrigins = new List<string>(SharedProperties.KnownOrigins);
            using (var context = ContextHelper.OpenContext())
            {
                var databaseOrigins = context.User.Select(u => u.Origin).Where(x => !string.IsNullOrWhiteSpace(x));

                foreach (var databaseOrigin in databaseOrigins)
                {
                    if (!outputOrigins.Any(oo =>
                        string.Equals(oo.Trim(), databaseOrigin.Trim(), StringComparison.InvariantCultureIgnoreCase)))
                    {
                        outputOrigins.Add(databaseOrigin.Trim());
                    }
                }
                    
            }

            var joinedNames = outputOrigins.Select(x => string.Format("'{0}'", x)).Aggregate((a, b) => a + ", " + b);
            return new HtmlString(joinedNames);
        }

        #endregion
    }
}