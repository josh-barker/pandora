using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.AnalysisServices.v2017_08_01.Servers
{
    [ConstantType(ConstantTypeAttribute.ConstantType.Integer)]
    internal enum ManagedMode
    {
        [Description("1")]
        One,

        [Description("0")]
        Zero,
    }
}