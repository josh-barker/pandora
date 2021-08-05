using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.PowerBIDedicated.v2021_01_01.Capacities
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "74dbcfee45a6634d0043e478aba324796d98940c" 

        public string ApiVersion => "2021-01-01";
        public string Name => "Capacities";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CheckNameAvailabilityOperation(),
            new CreateOperation(),
            new DeleteOperation(),
            new GetDetailsOperation(),
            new ListOperation(),
            new ListByResourceGroupOperation(),
            new ListSkusForCapacityOperation(),
            new ResumeOperation(),
            new SuspendOperation(),
            new UpdateOperation(),
        };
    }
}