using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.LabServices.v2021_10_01_preview.LabPlan
{
    internal class GetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new LabPlanId();

        public override Type? ResponseObject() => typeof(LabPlanModel);


    }
}