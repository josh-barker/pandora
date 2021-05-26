using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview
{
    public class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2018-01-01-preview";
        public bool Generate => true;
        public bool Preview => true;
        
        public IEnumerable<ApiDefinition> Apis => new List<ApiDefinition>
        {
            new AuthorizationRulesDisasterRecoveryConfigs.Definition(),
            new AuthorizationRulesEventHubs.Definition(),
            new AuthorizationRulesNamespaces.Definition(),
            new CheckNameAvailabilityDisasterRecoveryConfigs.Definition(),
            new ConsumerGroups.Definition(),
            new DisasterRecoveryConfigs.Definition(),
            new EventHubs.Definition(),
            new EventHubsClusters.Definition(),
            new EventHubsClustersConfiguration.Definition(),
            new EventHubsClustersNamespace.Definition(),
            new IpFilterRules.Definition(),
            new Namespaces.Definition(),
            new NamespacesPrivateEndpointConnections.Definition(),
            new NamespacesPrivateLinkResources.Definition(),
            new NetworkRuleSets.Definition(),
            new VirtualNetworkRules.Definition(),
        };
    }
}