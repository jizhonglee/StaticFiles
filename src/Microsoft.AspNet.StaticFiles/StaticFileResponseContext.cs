// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.FileSystems;
using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.StaticFiles
{
    /// <summary>
    /// Contains information about the request and the file that will be served in response.
    /// </summary>
    public class StaticFileResponseContext
    {
        /// <summary>
        /// The request and response information.
        /// </summary>
        public HttpContext Context { get; internal set; }

        /// <summary>
        /// The file to be served.
        /// </summary>
        public IFileInfo File { get; internal set; }
    }
}
