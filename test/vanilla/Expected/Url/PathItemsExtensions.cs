// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Url
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PathItems.
    /// </summary>
    public static partial class PathItemsExtensions
    {
            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery='globalStringQuery',
            /// pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery='localStringQuery'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value 'localStringQuery'
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            public static void GetAllWithValues(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
            {
                operations.GetAllWithValuesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery='globalStringQuery',
            /// pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery='localStringQuery'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value 'localStringQuery'
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAllWithValuesAsync(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetAllWithValuesWithHttpMessagesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery='localStringQuery'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value 'localStringQuery'
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            public static void GetGlobalQueryNull(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
            {
                operations.GetGlobalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery='localStringQuery'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value 'localStringQuery'
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetGlobalQueryNullAsync(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetGlobalQueryNullWithHttpMessagesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// send globalStringPath=globalStringPath,
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery=null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain null value
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            public static void GetGlobalAndLocalQueryNull(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
            {
                operations.GetGlobalAndLocalQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// send globalStringPath=globalStringPath,
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
            /// localStringQuery=null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain null value
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// A string value 'pathItemStringQuery' that appears as a query parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetGlobalAndLocalQueryNullAsync(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetGlobalAndLocalQueryNullWithHttpMessagesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery='globalStringQuery', pathItemStringQuery=null,
            /// localStringQuery=null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value null
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// should contain value null
            /// </param>
            public static void GetLocalPathItemQueryNull(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string))
            {
                operations.GetLocalPathItemQueryNullAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// send globalStringPath='globalStringPath',
            /// pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
            /// globalStringQuery='globalStringQuery', pathItemStringQuery=null,
            /// localStringQuery=null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='localStringPath'>
            /// should contain value 'localStringPath'
            /// </param>
            /// <param name='pathItemStringPath'>
            /// A string value 'pathItemStringPath' that appears in the path
            /// </param>
            /// <param name='localStringQuery'>
            /// should contain value null
            /// </param>
            /// <param name='pathItemStringQuery'>
            /// should contain value null
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetLocalPathItemQueryNullAsync(this IPathItems operations, string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetLocalPathItemQueryNullWithHttpMessagesAsync(localStringPath, pathItemStringPath, localStringQuery, pathItemStringQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
