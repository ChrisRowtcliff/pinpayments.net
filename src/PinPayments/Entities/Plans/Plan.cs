﻿namespace PinPayments.Entities.Plans
{
    using System;
    using System.Text.Json.Serialization;

    public class Plan : IEvent
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("setup_amount")]
        public int SetupAmount { get; set; }

        [JsonPropertyName("trial_amount")]
        public int TrialAmount { get; set; }

        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("interval_unit")]
        public PlanIntervalUnit IntervalUnit { get; set; }

        [JsonPropertyName("intervals")]
        public int Intervals { get; set; }

        [JsonPropertyName("trial_interval")]
        public int TrialInterval { get; set; }

        [JsonPropertyName("trial_interval_unit")]
        public PlanIntervalUnit TrialIntervalUnit { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("customer_permissions")]
        public CustomerPermissions[] CustomerPermissions { get; set; }

        [JsonPropertyName("subscription_counts")]
        public SubscriptionCount SubscriptionCounts { get; set; }
    }
}