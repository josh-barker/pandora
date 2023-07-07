using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2023_03_01_preview.POST;

internal class CheckMigrationNameAvailabilityOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(MigrationNameAvailabilityResourceModel);

    public override ResourceID? ResourceId() => new FlexibleServerId();

    public override Type? ResponseObject() => typeof(MigrationNameAvailabilityResourceModel);

    public override string? UriSuffix() => "/checkMigrationNameAvailability";


}
