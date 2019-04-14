namespace DsmWebApi.Dsm.Network
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// The network configuration of a DSM system.
    /// </summary>
    public class DsmNetworkConfiguration
    {
        /// <summary>
        /// Gets or sets the collection of configured DNS servers.
        /// </summary>
        [JsonProperty("dns")]
        public IEnumerable<string> DnsServers { get; set; }

        /// <summary>
        /// Gets or sets the network gateway address.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or sets the host name of the DSM system.
        /// </summary>
        [JsonProperty("hostname")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the workgroup of the DSM system.
        /// </summary>
        [JsonProperty("workgroup")]
        public string Workgroup { get; set; }

        /// <summary>
        /// Gets or sets the collection of all network interfaces.
        /// </summary>
        [JsonProperty("interfaces")]
        public IEnumerable<DsmNetworkInterface> Interfaces { get; set; }
    }
}
