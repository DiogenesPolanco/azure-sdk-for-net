// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Probe of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayProbeInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayProbeInner
        /// class.
        /// </summary>
        public ApplicationGatewayProbeInner() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayProbeInner
        /// class.
        /// </summary>
        /// <param name="protocol">Protocol. Possible values include: 'Http',
        /// 'Https'</param>
        /// <param name="host">Host to send probe to </param>
        /// <param name="path">Relative path of probe </param>
        /// <param name="interval">Probing interval in seconds </param>
        /// <param name="timeout">Probing timeout in seconds </param>
        /// <param name="unhealthyThreshold">Probing unhealthy threshold
        /// </param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayProbeInner(string id = default(string), string protocol = default(string), string host = default(string), string path = default(string), int? interval = default(int?), int? timeout = default(int?), int? unhealthyThreshold = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Protocol = protocol;
            Host = host;
            Path = path;
            Interval = interval;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets protocol. Possible values include: 'Http', 'Https'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets host to send probe to
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets relative path of probe
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets probing interval in seconds
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets probing timeout in seconds
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets probing unhealthy threshold
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.unhealthyThreshold")]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}