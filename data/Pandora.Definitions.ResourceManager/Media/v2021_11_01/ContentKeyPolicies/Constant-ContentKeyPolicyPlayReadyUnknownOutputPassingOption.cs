using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.ContentKeyPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ContentKeyPolicyPlayReadyUnknownOutputPassingOptionConstant
{
    [Description("Allowed")]
    Allowed,

    [Description("AllowedWithVideoConstriction")]
    AllowedWithVideoConstriction,

    [Description("NotAllowed")]
    NotAllowed,

    [Description("Unknown")]
    Unknown,
}
