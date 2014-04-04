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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Monitoring.Usages;
using Microsoft.WindowsAzure.Management.Monitoring.Usages.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Usages.Models
{
    /// <summary>
    /// Usage Metric data.
    /// </summary>
    public partial class UsageMetric
    {
        private double _currentValue;
        
        /// <summary>
        /// Optional. The current value for the usage metric.
        /// </summary>
        public double CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Get the usage display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private double _limit;
        
        /// <summary>
        /// Optional. The quota limit the usage metric.
        /// </summary>
        public double Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Get the usage metric name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private System.DateTime? _nextResetTime;
        
        /// <summary>
        /// Optional. When the current value gets reset.
        /// </summary>
        public System.DateTime? NextResetTime
        {
            get { return this._nextResetTime; }
            set { this._nextResetTime = value; }
        }
        
        private System.TimeSpan? _quotaPeriod;
        
        /// <summary>
        /// Optional. When the current value gets reset.
        /// </summary>
        public System.TimeSpan? QuotaPeriod
        {
            get { return this._quotaPeriod; }
            set { this._quotaPeriod = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. The unit for the usage metric.
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsageMetric class.
        /// </summary>
        public UsageMetric()
        {
        }
    }
    
    /// <summary>
    /// Represents collection of usage metrics.
    /// </summary>
    public partial class UsageMetricCollection
    {
        private IList<UsageMetric> _properties;
        
        /// <summary>
        /// Optional. The usage values.
        /// </summary>
        public IList<UsageMetric> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IList<UsageMetric> _value;
        
        /// <summary>
        /// Optional. The usage values.
        /// </summary>
        public IList<UsageMetric> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsageMetricCollection class.
        /// </summary>
        public UsageMetricCollection()
        {
            this._properties = new List<UsageMetric>();
            this._value = new List<UsageMetric>();
        }
    }
    
    /// <summary>
    /// The List Usage Metric operation response.
    /// </summary>
    public partial class UsageMetricListResponse : OperationResponse
    {
        private UsageMetricCollection _usageMetricCollection;
        
        /// <summary>
        /// Optional. The list of usage metrics.
        /// </summary>
        public UsageMetricCollection UsageMetricCollection
        {
            get { return this._usageMetricCollection; }
            set { this._usageMetricCollection = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsageMetricListResponse class.
        /// </summary>
        public UsageMetricListResponse()
        {
        }
    }
}

namespace Microsoft.WindowsAzure.Management.Monitoring.Usages
{
    public static partial class UsagesClientExtensions
    {
    }
    
    public partial interface IUsagesClient : IDisposable
    {
        /// <summary>
        /// Optional base uri parameter.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Windows Azure subscription id.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        IUsageMetricsOperations UsageMetrics
        {
            get; 
        }
    }
    
    public partial class UsagesClient : ServiceClient<UsagesClient>, IUsagesClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// Optional base uri parameter.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Windows Azure subscription id.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IUsageMetricsOperations _usageMetrics;
        
        public virtual IUsageMetricsOperations UsageMetrics
        {
            get { return this._usageMetrics; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsagesClient class.
        /// </summary>
        private UsagesClient()
            : base()
        {
            this._usageMetrics = new UsageMetricsOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the UsagesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Windows Azure subscription id.
        /// </param>
        /// <param name='baseUri'>
        /// Required. Optional base uri parameter.
        /// </param>
        public UsagesClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the UsagesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Windows Azure subscription id.
        /// </param>
        public UsagesClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
    }
    
    public static partial class UsageMetricsOperationsExtensions
    {
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Usages.IUsageMetricsOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required.
        /// </param>
        /// <param name='metricNames'>
        /// Required.
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        public static UsageMetricListResponse List(this IUsageMetricsOperations operations, string resourceUri, IList<string> metricNames)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageMetricsOperations)s).ListAsync(resourceUri, metricNames);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Usages.IUsageMetricsOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required.
        /// </param>
        /// <param name='metricNames'>
        /// Required.
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        public static Task<UsageMetricListResponse> ListAsync(this IUsageMetricsOperations operations, string resourceUri, IList<string> metricNames)
        {
            return operations.ListAsync(resourceUri, metricNames, CancellationToken.None);
        }
    }
    
    public partial interface IUsageMetricsOperations
    {
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        Task<UsageMetricListResponse> ListAsync(string resourceUri, IList<string> metricNames, CancellationToken cancellationToken);
    }
    
    internal partial class UsageMetricsOperations : IServiceOperations<UsagesClient>, IUsageMetricsOperations
    {
        /// <summary>
        /// Initializes a new instance of the UsageMetricsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal UsageMetricsOperations(UsagesClient client)
        {
            this._client = client;
        }
        
        private UsagesClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Usages.UsagesClient.
        /// </summary>
        public UsagesClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// Required.
        /// </param>
        /// <param name='metricNames'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        public async Task<UsageMetricListResponse> ListAsync(string resourceUri, IList<string> metricNames, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceUri == null)
            {
                throw new ArgumentNullException("resourceUri");
            }
            if (metricNames == null)
            {
                throw new ArgumentNullException("metricNames");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                tracingParameters.Add("metricNames", metricNames);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + resourceUri + "/usages?";
            url = url + "api-version=2014-01";
            url = url + "&names=" + Uri.EscapeUriString(string.Join(",", metricNames));
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
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2014-01");
                
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
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Json);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    UsageMetricListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new UsageMetricListResponse();
                    JToken responseDoc = null;
                    if (string.IsNullOrEmpty(responseContent) == false)
                    {
                        responseDoc = JToken.Parse(responseContent);
                    }
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        UsageMetricCollection usageMetricCollectionInstance = new UsageMetricCollection();
                        result.UsageMetricCollection = usageMetricCollectionInstance;
                        
                        JToken valueArray = responseDoc["value"];
                        if (valueArray != null && valueArray.Type != JTokenType.Null)
                        {
                            foreach (JToken valueValue in ((JArray)valueArray))
                            {
                                UsageMetric usageMetricInstance = new UsageMetric();
                                usageMetricCollectionInstance.Value.Add(usageMetricInstance);
                                
                                JToken nameValue = valueValue["name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = ((string)nameValue);
                                    usageMetricInstance.Name = nameInstance;
                                }
                                
                                JToken displayNameValue = valueValue["displayName"];
                                if (displayNameValue != null && displayNameValue.Type != JTokenType.Null)
                                {
                                    string displayNameInstance = ((string)displayNameValue);
                                    usageMetricInstance.DisplayName = displayNameInstance;
                                }
                                
                                JToken currentValueValue = valueValue["currentValue"];
                                if (currentValueValue != null && currentValueValue.Type != JTokenType.Null)
                                {
                                    double currentValueInstance = ((double)currentValueValue);
                                    usageMetricInstance.CurrentValue = currentValueInstance;
                                }
                                
                                JToken limitValue = valueValue["limit"];
                                if (limitValue != null && limitValue.Type != JTokenType.Null)
                                {
                                    double limitInstance = ((double)limitValue);
                                    usageMetricInstance.Limit = limitInstance;
                                }
                                
                                JToken unitValue = valueValue["unit"];
                                if (unitValue != null && unitValue.Type != JTokenType.Null)
                                {
                                    string unitInstance = ((string)unitValue);
                                    usageMetricInstance.Unit = unitInstance;
                                }
                                
                                JToken nextResetTimeValue = valueValue["nextResetTime"];
                                if (nextResetTimeValue != null && nextResetTimeValue.Type != JTokenType.Null)
                                {
                                    DateTime nextResetTimeInstance = ((DateTime)nextResetTimeValue);
                                    usageMetricInstance.NextResetTime = nextResetTimeInstance;
                                }
                                
                                JToken quotaPeriodValue = valueValue["quotaPeriod"];
                                if (quotaPeriodValue != null && quotaPeriodValue.Type != JTokenType.Null)
                                {
                                    TimeSpan quotaPeriodInstance = TypeConversion.From8601TimeSpan(((string)quotaPeriodValue));
                                    usageMetricInstance.QuotaPeriod = quotaPeriodInstance;
                                }
                            }
                        }
                        
                        JToken propertiesArray = responseDoc["properties"];
                        if (propertiesArray != null && propertiesArray.Type != JTokenType.Null)
                        {
                            foreach (JToken propertiesValue in ((JArray)propertiesArray))
                            {
                                UsageMetric usageMetricInstance2 = new UsageMetric();
                                usageMetricCollectionInstance.Properties.Add(usageMetricInstance2);
                                
                                JToken nameValue2 = propertiesValue["name"];
                                if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                                {
                                    string nameInstance2 = ((string)nameValue2);
                                    usageMetricInstance2.Name = nameInstance2;
                                }
                                
                                JToken displayNameValue2 = propertiesValue["displayName"];
                                if (displayNameValue2 != null && displayNameValue2.Type != JTokenType.Null)
                                {
                                    string displayNameInstance2 = ((string)displayNameValue2);
                                    usageMetricInstance2.DisplayName = displayNameInstance2;
                                }
                                
                                JToken currentValueValue2 = propertiesValue["currentValue"];
                                if (currentValueValue2 != null && currentValueValue2.Type != JTokenType.Null)
                                {
                                    double currentValueInstance2 = ((double)currentValueValue2);
                                    usageMetricInstance2.CurrentValue = currentValueInstance2;
                                }
                                
                                JToken limitValue2 = propertiesValue["limit"];
                                if (limitValue2 != null && limitValue2.Type != JTokenType.Null)
                                {
                                    double limitInstance2 = ((double)limitValue2);
                                    usageMetricInstance2.Limit = limitInstance2;
                                }
                                
                                JToken unitValue2 = propertiesValue["unit"];
                                if (unitValue2 != null && unitValue2.Type != JTokenType.Null)
                                {
                                    string unitInstance2 = ((string)unitValue2);
                                    usageMetricInstance2.Unit = unitInstance2;
                                }
                                
                                JToken nextResetTimeValue2 = propertiesValue["nextResetTime"];
                                if (nextResetTimeValue2 != null && nextResetTimeValue2.Type != JTokenType.Null)
                                {
                                    DateTime nextResetTimeInstance2 = ((DateTime)nextResetTimeValue2);
                                    usageMetricInstance2.NextResetTime = nextResetTimeInstance2;
                                }
                                
                                JToken quotaPeriodValue2 = propertiesValue["quotaPeriod"];
                                if (quotaPeriodValue2 != null && quotaPeriodValue2.Type != JTokenType.Null)
                                {
                                    TimeSpan quotaPeriodInstance2 = TypeConversion.From8601TimeSpan(((string)quotaPeriodValue2));
                                    usageMetricInstance2.QuotaPeriod = quotaPeriodInstance2;
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