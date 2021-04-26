﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using System.Collections.Generic;

namespace Sportradar.OddsFeed.SDK.Entities.REST
{
    /// <summary>
    /// Defines a contract implemented by classes representing period status
    /// </summary>
    public interface IPeriodStatus
    {
        /// <summary>
        /// Gets the number of the specific lap.
        /// </summary>
        /// <value>The number of the specific lap.</value>
        public int? Number { get; }

        /// <summary>
        /// Gets the type
        /// </summary>
        /// <value>The type</value>
        /// <remarks>Possible values: lap</remarks>
        public string Type { get; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        /// <remarks>Possible values: not_started, started, completed.</remarks>
        public string Status { get; }

        /// <summary>
        /// Gets the period results
        /// </summary>
        /// <value>The results</value>
        public IEnumerable<IPeriodCompetitorResult> PeriodResults { get; }
    }
}
