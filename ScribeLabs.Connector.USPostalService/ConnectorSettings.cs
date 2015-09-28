namespace Scribe.Connector.USPostalServiceAPI
{
    /// <summary>
    /// Used for Discovery. These constants are used to fill in some of the values in the
    /// ScribeConnectorAttrribute declaration on the class that implements IConnector.
    /// Connector settings that are often or must different from other connectors.
    /// </summary>
    public class ConnectorSettings
    {
        public const string ConnectorTypeId = "d16d7b48-fbb1-4df0-8356-dc44194927c2";
        public const string ConnectorVersion = "1.0";
        public const string Description = "United States Postal Service Tracking API";
        public const string Name = "USPostalService.API";
        public const bool SupportsCloud = true;

        public const string CompanyName = "Scribe";

        public const string AppName = "USPostalService.API";

        public const string Copyright = "Copyright © 2015 Scribe All rights reserved.";
    }
}
