namespace Scribe.Connector.USPostalServiceAPI
{
    using System;
    using System.Collections.Generic;

    using Simple.Connector.Framework.Http;

    using Models;

    public class USPostalServiceAPIConnectionInfo : HttpClientConnectionInfoBase<USPostalServiceAPIConnectionInfo>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string BaseUrl { get; set; }

        protected override IList<HttpQueryRegistration> ConfigureQueries()
        {
            var item = this.Queries.EnumerateResponseAs<Item, Root>("/Test", root => root);
            return new List<HttpQueryRegistration> { item };
        }

        protected override Func<USPostalServiceAPIConnectionInfo, IConnectionConfiguration> ConnectionConfiguration()
        {
            // Configure the way to connect that is appropriate for the API you are connecting to
            this.BaseUrl = "https://api.scribesoft.com";

            return this.Connection.ConfigureWithBasicAuth("GET", (form) => form.BaseUrl, this.Username, this.Password).End();
        }

        protected override IList<HttpCallDescription> ConfigureOperations()
        {
            // For each entity that supports target operations, configure an operation.
            var item = this.Operations.Create<Item>("/Items");

            return new List<HttpCallDescription> { item };
        }
    }
}
