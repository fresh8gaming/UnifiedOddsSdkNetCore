﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using System.Collections.Generic;
using System.Threading.Tasks;
using Sportradar.OddsFeed.SDK.Entities.Rest.CustomBet;
using Sportradar.OddsFeed.SDK.Entities.Rest.Internal.Dto.CustomBet;

namespace Sportradar.OddsFeed.SDK.Entities.Rest.Internal
{
    /// <summary>
    /// Defines a contract implemented by classes used to provide data probability calculations
    /// </summary>
    internal interface ICalculateProbabilityProvider
    {
        /// <summary>
        /// Asynchronously gets a <see cref="CalculationDto"/> instance
        /// </summary>
        /// <param name="selections">The <see cref="IEnumerable{ISelection}"/> containing selections for which the probability should be fetched</param>
        /// <returns>A <see cref="Task{CalculationDto}"/> representing the probability calculation</returns>
        Task<CalculationDto> GetDataAsync(IEnumerable<ISelection> selections);
    }
}
