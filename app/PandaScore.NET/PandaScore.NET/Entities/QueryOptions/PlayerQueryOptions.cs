﻿namespace PandaScore.NET.Entities.QueryOptions {
    /// <summary>
    /// Represents settings required to make a player query. Refer to each property's comments for usage.
    /// </summary>
    public class PlayerQueryOptions : QueryConfiguration {
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> FirstName { get; } = new QueryOption<string>("first_name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Country { get; } = new QueryOption<string>("hometown", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> Id { get; } = new QueryOption<int>("id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> ImageUrl { get; } = new QueryOption<string>("image_url", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> LastName { get; } = new QueryOption<string>("last_name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Name { get; } = new QueryOption<string>("name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. Acceptable values are: top, jun, mid, adc, sup. </summary>
        public QueryOption<PlayerRole> Role { get; } = new QueryOption<PlayerRole>("role", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Slug { get; } = new QueryOption<string>("slug", QueryOptionType.All);
    }
}
