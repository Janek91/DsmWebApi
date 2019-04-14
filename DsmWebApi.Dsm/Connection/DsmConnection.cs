﻿namespace DsmWebApi.Dsm.Connection
{
    using DsmWebApi.Core.Json;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// A connection to a DSM system.
    /// </summary>
    public class DsmConnection
    {
        /// <summary>
        /// Gets or sets the user who created the connection.
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the type of the connection.
        /// </summary>
        [JsonProperty("type")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the activity of the connection.
        /// </summary>
        [JsonProperty("activity")]
        public string Activity { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the user.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the local date and time at which the connection was created.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixTimestampToDateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}
