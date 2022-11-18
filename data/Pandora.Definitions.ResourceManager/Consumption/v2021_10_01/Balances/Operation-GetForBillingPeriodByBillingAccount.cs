using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2021_10_01.Balances;

internal class GetForBillingPeriodByBillingAccountOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new BillingAccountBillingPeriodId();

    public override Type? ResponseObject() => typeof(BalanceModel);

    public override string? UriSuffix() => "/providers/Microsoft.Consumption/balances";


}
