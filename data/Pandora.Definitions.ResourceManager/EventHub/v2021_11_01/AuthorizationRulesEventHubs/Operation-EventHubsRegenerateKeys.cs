using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_11_01.AuthorizationRulesEventHubs;

internal class EventHubsRegenerateKeysOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(RegenerateAccessKeyParametersModel);

    public override ResourceID? ResourceId() => new EventhubAuthorizationRuleId();

    public override Type? ResponseObject() => typeof(AccessKeysModel);

    public override string? UriSuffix() => "/regenerateKeys";


}