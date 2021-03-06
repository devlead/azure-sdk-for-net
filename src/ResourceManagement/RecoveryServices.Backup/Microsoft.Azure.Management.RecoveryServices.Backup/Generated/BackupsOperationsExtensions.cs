// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for BackupsOperations.
    /// </summary>
    public static partial class BackupsOperationsExtensions
    {
            /// <summary>
            /// Triggers backup for specified backed up item. This is an asynchronous
            /// operation. To know the status of the operation, call
            /// GetProtectedItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backup item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backup item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backup item for which backup needs to be triggered.
            /// </param>
            /// <param name='resourceBackupRequest'>
            /// resource backup request
            /// </param>
            public static void Trigger(this IBackupsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, BackupRequestResource resourceBackupRequest)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IBackupsOperations)s).TriggerAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, resourceBackupRequest), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers backup for specified backed up item. This is an asynchronous
            /// operation. To know the status of the operation, call
            /// GetProtectedItemOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the backup item.
            /// </param>
            /// <param name='containerName'>
            /// Container name associated with the backup item.
            /// </param>
            /// <param name='protectedItemName'>
            /// Backup item for which backup needs to be triggered.
            /// </param>
            /// <param name='resourceBackupRequest'>
            /// resource backup request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task TriggerAsync(this IBackupsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, BackupRequestResource resourceBackupRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.TriggerWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, resourceBackupRequest, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
