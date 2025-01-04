﻿using System;

namespace PandaScore.NET.Entities.QueryOptions {
    /// <summary>
    /// Represents settings required to make a series query. Refer to each property's comments for usage.
    /// </summary>
    public class SeriesQueryOptions : QueryConfiguration {
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<DateTime> BeginAt { get; } = new QueryOption<DateTime>("begin_at", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Description { get; } = new QueryOption<string>("description", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<DateTime> EndAt { get; } = new QueryOption<DateTime>("end_at", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> FullName { get; } = new QueryOption<string>("full_name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> Id { get; } = new QueryOption<int>("id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> LeagueId { get; } = new QueryOption<int>("league_id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<DateTime> ModifiedAt { get; } = new QueryOption<DateTime>("modified_at", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Name { get; } = new QueryOption<string>("name", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Prizepool { get; } = new QueryOption<string>("prizepool", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Season { get; } = new QueryOption<string>("season", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> Slug { get; } = new QueryOption<string>("slug", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> WinnerId { get; } = new QueryOption<int>("winner_id", QueryOptionType.FilterRangeSort);
        /// <summary>Can be used to filter, sort, range, or as a search term. </summary>
        public QueryOption<string> WinnerType { get; } = new QueryOption<string>("winner_type", QueryOptionType.All);
        /// <summary>Can be used to filter, sort, and range. </summary>
        public QueryOption<int> Year { get; } = new QueryOption<int>("year", QueryOptionType.FilterRangeSort);
    }
}
