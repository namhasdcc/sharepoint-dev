// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace WordAddInWeb.Models
{
    public class AzureAdOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string GraphScopes { get; set; }
        public string Authority { get; set; }
        public string SaaSAPI { get; set; }
        public string SaaSScopes { get; set; }

    }
}
