using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Purview.v2020_12_01_preview.Account
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "70de88e5fb00b9217a5cafd3c1bed11ce311fc52" 

        public string ApiVersion => "2020-12-01-preview";
        public string Name => "Account";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CreateOrUpdateOperation(),
            new DeleteOperation(),
            new GetOperation(),
            new ListByResourceGroupOperation(),
            new ListBySubscriptionOperation(),
            new ListKeysOperation(),
            new UpdateOperation(),
        };
    }
}