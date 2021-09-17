using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.AttestationProviders
{
    internal class GetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new AttestationProviderId();

        public override Type? ResponseObject() => typeof(AttestationProviderModel);


    }
}