using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.StoragePool.v2021_08_01.ResourceSkus
{

    internal class ResourceSkuLocationInfoModel
    {
        [JsonPropertyName("location")]
        public CustomTypes.Location? Location { get; set; }

        [JsonPropertyName("zoneDetails")]
        public List<ResourceSkuZoneDetailsModel>? ZoneDetails { get; set; }

        [JsonPropertyName("zones")]
        public List<string>? Zones { get; set; }
    }
}