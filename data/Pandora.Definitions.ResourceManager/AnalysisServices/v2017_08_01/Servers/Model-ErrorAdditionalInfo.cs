using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.AnalysisServices.v2017_08_01.Servers
{

    internal class ErrorAdditionalInfo
    {
        [JsonPropertyName("info")]
        public object? Info { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}