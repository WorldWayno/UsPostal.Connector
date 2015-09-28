namespace Scribe.Connector.USPostalServiceAPI
{
    using Simple.Connector.Framework;
    using Simple.Connector.Framework.Http;

    [SimpleConnector(
        ConnectorSettings.ConnectorTypeId,
        ConnectorSettings.Name,
        ConnectorSettings.Description,
        typeof(USPostalServiceAPIConnector),
        ConnectorSettings.SupportsCloud,
        ConnectorSettings.ConnectorVersion)]
    public class USPostalServiceAPIConnector : HttpConnectorBase<USPostalServiceAPIConnectionInfo>
    {
        public USPostalServiceAPIConnector()
            : base(ConnectorSettings.ConnectorTypeId)
        {

        }
    }
}
