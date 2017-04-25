// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsagesOperations.
    /// </summary>
    public static partial class UsagesOperationsExtensions
    {
            /// <summary>
            /// Fetches the usages of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            public static IEnumerable<VaultUsage> ListByVaults(this IUsagesOperations operations, string resourceGroupName, string vaultName)
            {
                return operations.ListByVaultsAsync(resourceGroupName, vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches the usages of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<VaultUsage>> ListByVaultsAsync(this IUsagesOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVaultsWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}