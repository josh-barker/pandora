using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2020_10_01.ResourceGroups;

internal class Definition : ResourceDefinition
{
    public string Name => "ResourceGroups";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CheckExistenceOperation(),
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new ExportTemplateOperation(),
        new GetOperation(),
        new ListOperation(),
        new ResourcesListByResourceGroupOperation(),
        new UpdateOperation(),
    };
}
