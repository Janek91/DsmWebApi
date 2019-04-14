﻿namespace DsmWebApi.Dsm.AutoBlock
{
    using DsmWebApi.Core;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Threading.Tasks;

    /// <summary>
    /// The DSM auto block API.
    /// </summary>
    public class DsmAutoBlockApi : DsmApiBase
    {
        /// <summary>
        /// The name of the DSM auto block API.
        /// </summary>
        private const string DsmAutoBlockApiName = "SYNO.DSM.AutoBlock";

        /// <summary>
        /// Initializes a new instance of the <see cref="DsmAutoBlockApi"/> class.
        /// </summary>
        /// <param name="dsmApiContext">The context used to access the DSM API.</param>
        public DsmAutoBlockApi(IDsmApiContext dsmApiContext)
            : base(dsmApiContext, DsmAutoBlockApiName, 1)
        {
        }

        /// <summary>
        /// Gets a list of blocked addresses on the DSM system.
        /// </summary>
        /// <param name="offset">The offset of the groups to retrieve in the list of groups.</param>
        /// <param name="limit">The number of groups to retrieve in the list of groups.</param>
        /// <returns>A list of blocked addresses on the DSM system.</returns>
        public async Task<DsmBlockedAddressCollection> List(int? offset, int? limit)
        {
            var parameters = new Dictionary<string, string>();
            if (offset.HasValue)
            {
                parameters.Add("offset", offset.Value.ToString(CultureInfo.InvariantCulture));
            }

            if (limit.HasValue)
            {
                parameters.Add("limit", limit.Value.ToString(CultureInfo.InvariantCulture));
            }

            DsmApiResponse response = await this.ApiContext.Request(
                this.ApiInfo.Path,
                DsmAutoBlockApiName,
                this.ApiInfo.MaxVersion,
                "list",
                parameters);
            var dsmBlockedAddressCollection = JsonConvert.DeserializeObject<DsmBlockedAddressCollection>(response.Data.ToString());
            return dsmBlockedAddressCollection;
        }

        /// <summary>
        /// Gets the Auto Block configuration.
        /// </summary>
        /// <returns>The Auto Block configuration.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "The method can perform a time-consuming operation. The method can be perceivably slower than the time that is required to set or get the value of a field.")]
        public async Task<DsmAutoBlockConfiguration> GetConfig()
        {
            DsmApiResponse response = await this.ApiContext.Request(
                this.ApiInfo.Path,
                DsmAutoBlockApiName,
                this.ApiInfo.MaxVersion,
                "getconfig",
                null);
            var dsmAutoBlockConfiguration = JsonConvert.DeserializeObject<DsmAutoBlockConfiguration>(response.Data.ToString());
            return dsmAutoBlockConfiguration;
        }

        /// <summary>
        /// Sets the Auto Block configuration.
        /// </summary>
        /// <param name="configuration">The new value of the configuration.</param>
        /// <returns>The response of the set configuration request.</returns>
        public async Task<DsmApiResponse> SetConfig(DsmAutoBlockConfiguration configuration)
        {
            DsmApiResponse response = await this.ApiContext.Request(
                this.ApiInfo.Path,
                DsmAutoBlockApiName,
                this.ApiInfo.MaxVersion,
                "setconfig",
                new Dictionary<string, string>()
                {
                    { "attemptmin", configuration.AttemptsPeriod.ToString(CultureInfo.InvariantCulture) },
                    { "attempts", configuration.Attempts.ToString(CultureInfo.InvariantCulture) },
                    { "expiredday", configuration.ExpiredDay.ToString(CultureInfo.InvariantCulture) }
                });
            return response;
        }
    }
}
