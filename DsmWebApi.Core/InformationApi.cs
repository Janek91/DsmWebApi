﻿namespace DsmWebApi.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// The core information API.
    /// </summary>
    public class InformationApi : DsmApiBase
    {
        /// <summary>
        /// The name of the information API.
        /// </summary>
        private const string InformationApiName = "SYNO.API.Info";

        /// <summary>
        /// Initializes a new instance of the <see cref="InformationApi"/> class.
        /// </summary>
        /// <param name="dsmApiContext">The context used to access the DSM API.</param>
        public InformationApi(IDsmApiContext dsmApiContext)
            : base(dsmApiContext, InformationApiName, 1)
        {
        }

        /// <summary>
        /// Gets the information about all available APIs.
        /// </summary>
        /// <returns>The information about all available APIs.</returns>
        public async Task<IDictionary<string, DsmApiInfo>> QueryAll()
        {
            DsmApiResponse response = await this.ApiContext.Request(
                this.ApiInfo.Path,
                InformationApiName,
                this.ApiInfo.MaxVersion,
                "query",
                new Dictionary<string, string>()
                {
                    { "query", "all" }
                });

            var allApiInfo = JsonConvert.DeserializeObject<Dictionary<string, DsmApiInfo>>(response.Data.ToString());
            return allApiInfo;
        }
    }
}
