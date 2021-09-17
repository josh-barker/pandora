using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_07_01.Provider
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "70de88e5fb00b9217a5cafd3c1bed11ce311fc52" 

        public string ApiVersion => "2021-07-01";
        public string Name => "Provider";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new AccountsCheckNameAvailabilityOperation(),
        };
    }
}