using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Scribe.Connector.USPostalServiceAPI;
using Scribe.Core.ConnectorApi.Query;

namespace USPostalConnector.Tests
{
    [TestFixture]
    public class ConnectionTests
    {
        [Test]
        public void Can_Get_Connection_Info()
        {
            var connector = new USPostalServiceAPIConnector();
            var properties = new Dictionary<string, string>();
            properties.Add("Username", "wayne.lewalski@scribesoft.com");
            properties.Add("Password","Abc123");

            Assert.IsNotNull(connector);

            connector.Connect(properties);

            Assert.IsTrue(connector.IsConnected);

           var entity = connector.ExecuteQuery(new Query());
        }
    }
}
