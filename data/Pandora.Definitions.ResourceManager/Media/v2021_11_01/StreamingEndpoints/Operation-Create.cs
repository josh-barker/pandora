using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.StreamingEndpoints;

internal class CreateOperation : Operations.PutOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(StreamingEndpointModel);

    public override ResourceID? ResourceId() => new StreamingEndpointId();

    public override Type? ResponseObject() => typeof(StreamingEndpointModel);

    public override Type? OptionsObject() => typeof(CreateOperation.CreateOptions);

    internal class CreateOptions
    {
        [QueryStringName("autoStart")]
        [Optional]
        public bool AutoStart { get; set; }
    }
}
