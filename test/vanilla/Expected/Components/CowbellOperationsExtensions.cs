// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Components
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CowbellOperations.
    /// </summary>
    public static partial class CowbellOperationsExtensions
    {
            /// <summary>
            /// A swell description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Cowbell Get(this ICowbellOperations operations, long id)
            {
                return operations.GetAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// A swell description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cowbell> GetAsync(this ICowbellOperations operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A good description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void Add(this ICowbellOperations operations, Cowbell body)
            {
                operations.AddAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// A good description.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddAsync(this ICowbellOperations operations, Cowbell body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Empty(this ICowbellOperations operations)
            {
                operations.EmptyAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EmptyAsync(this ICowbellOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetImplementationAgnostic(this ICowbellOperations operations)
            {
                operations.GetImplementationAgnosticAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetImplementationAgnosticAsync(this ICowbellOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetImplementationAgnosticWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetImplementationSpecific(this ICowbellOperations operations)
            {
                operations.GetImplementationSpecificAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetImplementationSpecificAsync(this ICowbellOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetImplementationSpecificWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void GetForwardTo(this ICowbellOperations operations, long id)
            {
                operations.GetForwardToAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetForwardToAsync(this ICowbellOperations operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetForwardToWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetForwardToCustomArgs1(this ICowbellOperations operations)
            {
                operations.GetForwardToCustomArgs1Async().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetForwardToCustomArgs1Async(this ICowbellOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetForwardToCustomArgs1WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void GetForwardToCustomArgs2(this ICowbellOperations operations, string name, long id)
            {
                operations.GetForwardToCustomArgs2Async(name, id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetForwardToCustomArgs2Async(this ICowbellOperations operations, string name, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetForwardToCustomArgs2WithHttpMessagesAsync(name, id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='idx'>
            /// </param>
            public static void GetForwardToCustomArgs3(this ICowbellOperations operations, string name, long idx)
            {
                operations.GetForwardToCustomArgs3Async(name, idx).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='idx'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetForwardToCustomArgs3Async(this ICowbellOperations operations, string name, long idx, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetForwardToCustomArgs3WithHttpMessagesAsync(name, idx, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='idx'>
            /// </param>
            public static void GetForwardToCustomArgs4(this ICowbellOperations operations, string name, long idx)
            {
                operations.GetForwardToCustomArgs4Async(name, idx).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='idx'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetForwardToCustomArgs4Async(this ICowbellOperations operations, string name, long idx, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetForwardToCustomArgs4WithHttpMessagesAsync(name, idx, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
