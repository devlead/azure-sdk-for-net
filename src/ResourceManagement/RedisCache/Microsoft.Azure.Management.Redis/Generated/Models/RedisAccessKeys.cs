// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System.Linq;

    /// <summary>
    /// Redis cache access keys.
    /// </summary>
    public partial class RedisAccessKeys
    {
        /// <summary>
        /// Initializes a new instance of the RedisAccessKeys class.
        /// </summary>
        public RedisAccessKeys() { }

        /// <summary>
        /// Initializes a new instance of the RedisAccessKeys class.
        /// </summary>
        /// <param name="primaryKey">The current primary key that clients can
        /// use to authenticate with redis cache.</param>
        /// <param name="secondaryKey">The current secondary key that clients
        /// can use to authenticate with redis cache.</param>
        public RedisAccessKeys(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary>
        /// Gets the current primary key that clients can use to authenticate
        /// with redis cache.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; private set; }

        /// <summary>
        /// Gets the current secondary key that clients can use to
        /// authenticate with redis cache.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; private set; }

    }
}
