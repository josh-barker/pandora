using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_12_01.AppPlatform;

internal class AppsGetOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new AppId();

    public override Type? ResponseObject() => typeof(AppResourceModel);

    public override Type? OptionsObject() => typeof(AppsGetOperation.AppsGetOptions);

    internal class AppsGetOptions
    {
        [QueryStringName("syncStatus")]
        [Optional]
        public string SyncStatus { get; set; }
    }
}
