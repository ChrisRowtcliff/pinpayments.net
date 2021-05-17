﻿namespace PinPayments
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PinList<T> : List<T>, IEnumerable<T>, IPinList
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("previous")]
        public int? Previous { get; set; }

        [JsonPropertyName("next")]
        public int? Next { get; set; }

        [JsonPropertyName("per_page")]
        public int PageSize { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonPropertyName("count")]
        public int Total { get; set; }
    }
}