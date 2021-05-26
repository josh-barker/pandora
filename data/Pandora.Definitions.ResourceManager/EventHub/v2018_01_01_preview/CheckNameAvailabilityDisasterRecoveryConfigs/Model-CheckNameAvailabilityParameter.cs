using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.CheckNameAvailabilityDisasterRecoveryConfigs
{

	internal class CheckNameAvailabilityParameter
	{
		[JsonPropertyName("name")]
		[Required]
		public string Name { get; set; }
	}
}