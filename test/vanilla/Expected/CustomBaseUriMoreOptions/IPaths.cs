// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.CustomBaseUriMoreOptions
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Paths operations.
    /// </summary>
    public partial interface IPaths
    {
        /// <summary>
        /// Get a 200 to test a valid base uri
        /// </summary>
        /// <param name='vault'>
        /// The vault name, e.g. https://myvault
        /// </param>
        /// <param name='secret'>
        /// Secret value.
        /// </param>
        /// <param name='keyName'>
        /// The key name with value 'key1'.
        /// </param>
        /// <param name='keyVersion'>
        /// The key version. Default value 'v1'.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> GetEmptyWithHttpMessagesAsync(string vault, string secret, string keyName, string keyVersion = "v1", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
