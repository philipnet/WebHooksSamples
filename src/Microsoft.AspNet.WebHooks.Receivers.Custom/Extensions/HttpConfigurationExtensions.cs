﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel;
using Microsoft.AspNet.WebHooks.Config;

namespace System.Web.Http
{
    /// <summary>
    /// Extension methods for <see cref="HttpConfiguration"/>.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class HttpConfigurationExtensions
    {
        /// <summary>
        /// Initializes support for receiving custom WebHooks.
        /// This can be used to receive WebHooks from multiple parties supporting WebHooks generated by
        /// ASP.NET custom WebHooks. Each party can have a separate shared secret used to sign its WebHook requests. Define an application
        /// setting named '<c>MS_WebHookReceiverSecret_Custom_&lt;name&gt;</c>' containing the secret for each party. The 
        /// corresponding WebHook URI is of the form '<c>https://&lt;host&gt;/api/webhooks/incoming/&lt;name&gt;</c>'.
        /// </summary>
        /// <param name="config">The current <see cref="HttpConfiguration"/>config.</param>
        public static void InitializeReceiveCustomWebHooks(this HttpConfiguration config)
        {
            WebHooksConfig.Initialize(config);
        }
    }
}
