using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Views
{

    internal class ReportConfigComparisonExpressionModel
    {
        [JsonPropertyName("name")]
        [Required]
        public string Name { get; set; }

        [JsonPropertyName("operator")]
        [Required]
        public OperatorTypeConstant Operator { get; set; }

        [MinItems(1)]
        [JsonPropertyName("values")]
        [Required]
        public List<string> Values { get; set; }
    }
}