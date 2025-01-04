﻿namespace PandaScore.NET.Entities.QueryOptions {
    /// <summary>
    /// Represents settings required to make a rune query. Refer to each property's comments for usage.
    /// </summary>
    public class RuneQueryOptions : QueryConfiguration {
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> Id { get; } = new QueryOption<int>("id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<string> Name { get; } = new QueryOption<string>("name", QueryOptionType.All);
    }
}
