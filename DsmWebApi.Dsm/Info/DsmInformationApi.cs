﻿namespace DsmWebApi.Dsm.Info
{
    using DsmWebApi.Core;
    using Newtonsoft.Json;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    /// <summary>
    /// The DSM information API.
    /// </summary>
    public class DsmInformationApi : DsmApiBase
    {
        /// <summary>
        /// The name of the DSM information API.
        /// </summary>
        private const string DsmInformationApiName = "SYNO.DSM.Info";

        /// <summary>
        /// Initializes a new instance of the <see cref="DsmInformationApi"/> class.
        /// </summary>
        /// <param name="dsmApiContext">The context used to access the DSM API.</param>
        public DsmInformationApi(IDsmApiContext dsmApiContext)
            : base(dsmApiContext, DsmInformationApiName, 1)
        {
        }

        /// <summary>
        /// Gets information about the DSM system.
        /// </summary>
        /// <returns>The information about the DSM system.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "The method can perform a time-consuming operation. The method can be perceivably slower than the time that is required to set or get the value of a field.")]
        public async Task<DsmInformation> GetInfo()
        {
            DsmApiResponse response = await this.ApiContext.Request(
                this.ApiInfo.Path,
                DsmInformationApiName,
                this.ApiInfo.MaxVersion,
                "getinfo",
                null);
            var dsmInfo = JsonConvert.DeserializeObject<DsmInformation>(response.Data.ToString());
            return dsmInfo;
        }
    }
}
