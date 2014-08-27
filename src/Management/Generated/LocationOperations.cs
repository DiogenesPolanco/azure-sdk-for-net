// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management
{
    /// <summary>
    /// The Service Management API includes operations for listing the
    /// available data center locations for a hosted service in your
    /// subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441299.aspx for
    /// more information)
    /// </summary>
    internal partial class LocationOperations : IServiceOperations<ManagementClient>, Microsoft.WindowsAzure.Management.ILocationOperations
    {
        /// <summary>
        /// Initializes a new instance of the LocationOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal LocationOperations(ManagementClient client)
        {
            this._client = client;
        }
        
        private ManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.ManagementClient.
        /// </summary>
        public ManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List Locations operation lists all of the data center locations
        /// that are valid for your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441293.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Locations operation response.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Models.LocationsListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/locations";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2014-05-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    LocationsListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new LocationsListResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement locationsSequenceElement = responseDoc.Element(XName.Get("Locations", "http://schemas.microsoft.com/windowsazure"));
                    if (locationsSequenceElement != null)
                    {
                        result.Locations = new List<LocationsListResponse.Location>();
                        foreach (XElement locationsElement in locationsSequenceElement.Elements(XName.Get("Location", "http://schemas.microsoft.com/windowsazure")))
                        {
                            LocationsListResponse.Location locationInstance = new LocationsListResponse.Location();
                            result.Locations.Add(locationInstance);
                            
                            XElement nameElement = locationsElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                locationInstance.Name = nameInstance;
                            }
                            
                            XElement displayNameElement = locationsElement.Element(XName.Get("DisplayName", "http://schemas.microsoft.com/windowsazure"));
                            if (displayNameElement != null)
                            {
                                string displayNameInstance = displayNameElement.Value;
                                locationInstance.DisplayName = displayNameInstance;
                            }
                            
                            XElement availableServicesSequenceElement = locationsElement.Element(XName.Get("AvailableServices", "http://schemas.microsoft.com/windowsazure"));
                            if (availableServicesSequenceElement != null)
                            {
                                locationInstance.AvailableServices = new List<string>();
                                foreach (XElement availableServicesElement in availableServicesSequenceElement.Elements(XName.Get("AvailableService", "http://schemas.microsoft.com/windowsazure")))
                                {
                                    locationInstance.AvailableServices.Add(availableServicesElement.Value);
                                }
                            }
                            
                            XElement computeCapabilitiesElement = locationsElement.Element(XName.Get("ComputeCapabilities", "http://schemas.microsoft.com/windowsazure"));
                            if (computeCapabilitiesElement != null)
                            {
                                ComputeCapabilities computeCapabilitiesInstance = new ComputeCapabilities();
                                locationInstance.ComputeCapabilities = computeCapabilitiesInstance;
                                
                                XElement virtualMachinesRoleSizesSequenceElement = computeCapabilitiesElement.Element(XName.Get("VirtualMachinesRoleSizes", "http://schemas.microsoft.com/windowsazure"));
                                if (virtualMachinesRoleSizesSequenceElement != null)
                                {
                                    computeCapabilitiesInstance.VirtualMachinesRoleSizes = new List<string>();
                                    foreach (XElement virtualMachinesRoleSizesElement in virtualMachinesRoleSizesSequenceElement.Elements(XName.Get("RoleSize", "http://schemas.microsoft.com/windowsazure")))
                                    {
                                        computeCapabilitiesInstance.VirtualMachinesRoleSizes.Add(virtualMachinesRoleSizesElement.Value);
                                    }
                                }
                                
                                XElement webWorkerRoleSizesSequenceElement = computeCapabilitiesElement.Element(XName.Get("WebWorkerRoleSizes", "http://schemas.microsoft.com/windowsazure"));
                                if (webWorkerRoleSizesSequenceElement != null)
                                {
                                    computeCapabilitiesInstance.WebWorkerRoleSizes = new List<string>();
                                    foreach (XElement webWorkerRoleSizesElement in webWorkerRoleSizesSequenceElement.Elements(XName.Get("RoleSize", "http://schemas.microsoft.com/windowsazure")))
                                    {
                                        computeCapabilitiesInstance.WebWorkerRoleSizes.Add(webWorkerRoleSizesElement.Value);
                                    }
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
