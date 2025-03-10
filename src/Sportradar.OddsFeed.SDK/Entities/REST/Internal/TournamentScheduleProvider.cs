﻿/*
* Copyright (C) Sportradar AG. See LICENSE for full license governing this code
*/
using Dawn;
using Sportradar.OddsFeed.SDK.Api.Internal.ApiAccess;
using Sportradar.OddsFeed.SDK.Common.Internal;
using Sportradar.OddsFeed.SDK.Entities.Rest.Internal.Dto;
using Sportradar.OddsFeed.SDK.Entities.Rest.Internal.Mapping;
using Sportradar.OddsFeed.SDK.Messages.Rest;

namespace Sportradar.OddsFeed.SDK.Entities.Rest.Internal
{
    /// <summary>
    /// A <see cref="IDataProvider{ISportEventsSchedule}"/> used to retrieve sport events scheduled for a specified date
    /// or currently live sport events
    /// </summary>
    /// <seealso cref="DataProvider{tournamentSchedule, EntityList}" />
    /// <seealso cref="IDataProvider{EntityList}" />
    internal class TournamentScheduleProvider : DataProvider<tournamentSchedule, EntityList<SportEventSummaryDto>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TournamentScheduleProvider"/> class
        /// </summary>
        /// <param name="dateScheduleUriFormat">An address format used to retrieve sport events for a specified date</param>
        /// <param name="dataFetcher">A <see cref="IDataFetcher" /> used to fetch the data</param>
        /// <param name="deserializer">A <see cref="IDeserializer{scheduleType}" /> used to deserialize the fetch data</param>
        /// <param name="mapperFactory">A <see cref="ISingleTypeMapperFactory{scheduleType, EntityList}" /> used to construct instances of <see cref="ISingleTypeMapper{ISportEventsSchedule}" /></param>
        public TournamentScheduleProvider(
            string dateScheduleUriFormat,
            IDataFetcher dataFetcher,
            IDeserializer<tournamentSchedule> deserializer,
            ISingleTypeMapperFactory<tournamentSchedule, EntityList<SportEventSummaryDto>> mapperFactory)
            : base(dateScheduleUriFormat, dataFetcher, deserializer, mapperFactory)
        {
            Guard.Argument(dateScheduleUriFormat, nameof(dateScheduleUriFormat)).NotNull().NotEmpty();
            Guard.Argument(dataFetcher, nameof(dataFetcher)).NotNull();
            Guard.Argument(deserializer, nameof(deserializer)).NotNull();
            Guard.Argument(mapperFactory, nameof(mapperFactory)).NotNull();
        }
    }
}
