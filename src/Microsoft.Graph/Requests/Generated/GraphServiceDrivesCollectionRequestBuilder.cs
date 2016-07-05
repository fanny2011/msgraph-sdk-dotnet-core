// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceDrivesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDrivesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDrivesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDrivesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDrivesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDrivesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDrivesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDrivesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDriveRequestBuilder"/> for the specified GraphServiceDrive.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDrive.</param>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        public IDriveRequestBuilder this[string id]
        {
            get
            {
                return new DriveRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
