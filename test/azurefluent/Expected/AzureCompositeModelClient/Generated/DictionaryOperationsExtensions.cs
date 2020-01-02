// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DictionaryOperations.
    /// </summary>
    public static partial class DictionaryOperationsExtensions
    {
            /// <summary>
            /// Get complex types with dictionary property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DictionaryWrapperInner GetValid(this IDictionaryOperations operations)
            {
                return operations.GetValidAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with dictionary property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DictionaryWrapperInner> GetValidAsync(this IDictionaryOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with dictionary property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='defaultProgram'>
            /// </param>
            public static void PutValid(this IDictionaryOperations operations, IDictionary<string, string> defaultProgram = default(IDictionary<string, string>))
            {
                operations.PutValidAsync(defaultProgram).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with dictionary property
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='defaultProgram'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutValidAsync(this IDictionaryOperations operations, IDictionary<string, string> defaultProgram = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutValidWithHttpMessagesAsync(defaultProgram, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with dictionary property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DictionaryWrapperInner GetEmpty(this IDictionaryOperations operations)
            {
                return operations.GetEmptyAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with dictionary property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DictionaryWrapperInner> GetEmptyAsync(this IDictionaryOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with dictionary property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='defaultProgram'>
            /// </param>
            public static void PutEmpty(this IDictionaryOperations operations, IDictionary<string, string> defaultProgram = default(IDictionary<string, string>))
            {
                operations.PutEmptyAsync(defaultProgram).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with dictionary property which is empty
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='defaultProgram'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutEmptyAsync(this IDictionaryOperations operations, IDictionary<string, string> defaultProgram = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutEmptyWithHttpMessagesAsync(defaultProgram, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with dictionary property which is null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DictionaryWrapperInner GetNull(this IDictionaryOperations operations)
            {
                return operations.GetNullAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with dictionary property which is null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DictionaryWrapperInner> GetNullAsync(this IDictionaryOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get complex types with dictionary property while server doesn't provide a
            /// response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DictionaryWrapperInner GetNotProvided(this IDictionaryOperations operations)
            {
                return operations.GetNotProvidedAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with dictionary property while server doesn't provide a
            /// response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DictionaryWrapperInner> GetNotProvidedAsync(this IDictionaryOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNotProvidedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
