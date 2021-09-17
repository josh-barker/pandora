using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.PrivateEndpointConnections
{
    internal class AttestationProviderId : ResourceID
    {
        public string ID() => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Attestation/attestationProvider/{providerName}";
    }
}