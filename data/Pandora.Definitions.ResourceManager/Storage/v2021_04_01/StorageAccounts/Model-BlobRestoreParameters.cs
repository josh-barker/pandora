using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.StorageAccounts;


internal class BlobRestoreParametersModel
{
    [JsonPropertyName("blobRanges")]
    [Required]
    public List<BlobRestoreRangeModel> BlobRanges { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("timeToRestore")]
    [Required]
    public DateTime TimeToRestore { get; set; }
}