using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.v2020_06_01.PrivateEndpointConnections
{
	internal class Get : GetOperation
	{
		public override ResourceID? ResourceId()
		{
			return new PrivateEndpointConnectionId();
		}

		public override object? ResponseObject()
		{
			return new PrivateEndpointConnection();
		}
	}
}