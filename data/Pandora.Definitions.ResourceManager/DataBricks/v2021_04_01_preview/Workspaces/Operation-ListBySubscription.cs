using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.DataBricks.v2021_04_01_preview.Workspaces
{
    internal class ListBySubscriptionOperation : Operations.ListOperation
    {
        public override string? FieldContainingPaginationDetails() => "nextLink";

        public override ResourceID? ResourceId() => new SubscriptionId();

        public override Type NestedItemType() => typeof(WorkspaceModel);

        public override string? UriSuffix() => "/providers/Microsoft.Databricks/workspaces";


    }
}