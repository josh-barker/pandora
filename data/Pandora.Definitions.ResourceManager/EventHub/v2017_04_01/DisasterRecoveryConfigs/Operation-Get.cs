using Pandora.Definitions.Operations;
using System.Collections.Generic;
using System.Net;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2017_04_01.DisasterRecoveryConfigs
{
	internal class Get : GetOperation
	{
		public override ResourceID? ResourceId()
		{
			return new DisasterRecoveryConfigId();
		}

		public override object? ResponseObject()
		{
			return new ArmDisasterRecovery();
		}
	}
}