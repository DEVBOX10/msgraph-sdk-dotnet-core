// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    /// <summary>
    /// An interface used to pass auth provider options in a request.
    /// Auth providers will be in charge of implementing this interface and providing <see cref="IBaseRequest"/> extensions to set it's values.
    /// </summary>
    public class CaeAuthenticationProviderOption : ICaeAuthenticationProviderOption
    {
        /// <summary>
        /// Microsoft Graph scopes property.
        /// </summary>
        public string[] Scopes { get; set; }

        /// <summary>
        /// Claims challenge for the authentication
        /// </summary>
        public string Claims { get; set; }
    }
}