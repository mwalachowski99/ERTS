﻿namespace PandaScore.NET.Entities.QueryOptions {
    /// <summary>
    /// Represents settings required to make a spell query. Refer to each property's comments for usage.
    /// </summary>
    public class SpellQueryOptions : QueryConfiguration {
        /// <summary>Can be used to filter, sort, and give a value range to a query.</summary>
        public QueryOption<int> Id { get; } = new QueryOption<int>("id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<string> Name { get; } = new QueryOption<string>("name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<string> ImageUrl { get; } = new QueryOption<string>("image_url", QueryOptionType.All);
    }
}
