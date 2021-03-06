// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for CustomImageOperations.
    /// </summary>
    public static partial class CustomImageOperationsExtensions
    {
            /// <summary>
            /// List custom images in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<CustomImage> List(this ICustomImageOperations operations, string resourceGroupName, string labName, ODataQuery<CustomImage> odataQuery = default(ODataQuery<CustomImage>))
            {
                return Task.Factory.StartNew(s => ((ICustomImageOperations)s).ListAsync(resourceGroupName, labName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List custom images in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomImage>> ListAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, ODataQuery<CustomImage> odataQuery = default(ODataQuery<CustomImage>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get custom image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            public static CustomImage GetResource(this ICustomImageOperations operations, string resourceGroupName, string labName, string name)
            {
                return Task.Factory.StartNew(s => ((ICustomImageOperations)s).GetResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get custom image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomImage> GetResourceAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing custom image. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='customImage'>
            /// </param>
            public static CustomImage CreateOrUpdateResource(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CustomImage customImage)
            {
                return Task.Factory.StartNew(s => ((ICustomImageOperations)s).CreateOrUpdateResourceAsync(resourceGroupName, labName, name, customImage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing custom image. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='customImage'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomImage> CreateOrUpdateResourceAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CustomImage customImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, customImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing custom image. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='customImage'>
            /// </param>
            public static CustomImage BeginCreateOrUpdateResource(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CustomImage customImage)
            {
                return Task.Factory.StartNew(s => ((ICustomImageOperations)s).BeginCreateOrUpdateResourceAsync(resourceGroupName, labName, name, customImage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing custom image. This operation can take a
            /// while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='customImage'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomImage> BeginCreateOrUpdateResourceAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CustomImage customImage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, customImage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete custom image. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            public static void DeleteResource(this ICustomImageOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((ICustomImageOperations)s).DeleteResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete custom image. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteResourceAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete custom image. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            public static void BeginDeleteResource(this ICustomImageOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((ICustomImageOperations)s).BeginDeleteResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete custom image. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the custom image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteResourceAsync(this ICustomImageOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// List custom images in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CustomImage> ListNext(this ICustomImageOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((ICustomImageOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List custom images in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomImage>> ListNextAsync(this ICustomImageOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
