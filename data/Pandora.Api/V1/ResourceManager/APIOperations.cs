using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Pandora.Api.V1.Helpers;
using Pandora.Data.Models;
using Pandora.Data.Repositories;

namespace Pandora.Api.V1.ResourceManager
{
    [ApiController]
    public class ApiOperationsController : ControllerBase
    {
        private readonly IServiceReferencesRepository _repo;

        public ApiOperationsController(IServiceReferencesRepository repo)
        {
            _repo = repo;
        }

        [Route("/v1/resource-manager/services/{serviceName}/{apiVersion}/{resourceName}/operations")]
        public IActionResult ResourceManager(string serviceName, string apiVersion, string resourceName)
        {
            return ForService(serviceName, apiVersion, resourceName);
        }

        private IActionResult ForService(string serviceName, string apiVersion, string resourceName)
        {
            var service = _repo.GetByName(serviceName, true);
            if (service == null)
            {
                return BadRequest("service not found");
            }

            var version = service.Versions.FirstOrDefault(v => v.Version == apiVersion);
            if (version == null)
            {
                return BadRequest($"version {apiVersion} was not found");
            }

            var api = version.Apis.FirstOrDefault(a => a.Name == resourceName);
            if (api == null)
            {
                return BadRequest($"resource {resourceName} was not found");
            }

            return new JsonResult(MapResponse(api, version, service));
        }

        private static ApiOperationsResponse MapResponse(ApiDefinition api, VersionDefinition version, ServiceDefinition service)
        {
            var metaData = new OperationMetaData
            {
                ResourceProvider = service.ResourceProvider!,
            };

            return new ApiOperationsResponse
            {
                MetaData = metaData,
                Operations = api.Operations.ToDictionary(o => o.Name, o => MapOperation(o, version.Version))
            };
        }

        private static ApiOperationDefinition MapOperation(OperationDefinition definition, string apiVersion)
        {
            var operation = new ApiOperationDefinition
            {
                ContentType = definition.ContentType,
                Method = definition.Method,
                LongRunning = definition.LongRunning,
                ExpectedStatusCodes = definition.ExpectedStatusCodes,
                ResourceIdName = definition.ResourceIdName,
                UriSuffix = definition.UriSuffix,
                FieldContainingPaginationDetails = definition.FieldContainingPaginationDetails,
                RequestObject = ApiObjectDefinitionMapper.Map(definition.RequestObject),
                ResponseObject = ApiObjectDefinitionMapper.Map(definition.ResponseObject),
            };

            operation.Options = MapOptions(definition.Options);

            // we should only return this if it's a different API version than the original
            if (apiVersion != definition.ApiVersion)
            {
                operation.ApiVersion = definition.ApiVersion;
            }

            return operation;
        }

        private static Dictionary<string, ApiOperationOption> MapOptions(List<OptionDefinition> input)
        {
            var output = new Dictionary<string, ApiOperationOption>();

            foreach (var definition in input)
            {
                var objectDefinition = ApiObjectDefinitionMapper.Map(definition.ObjectDefinition);
                output[definition.Name] = new ApiOperationOption
                {
                    QueryStringName = definition.QueryStringName,
                    ObjectDefinition = objectDefinition,
                    Required = definition.Required,
                };
            }

            return output;
        }

        public class ApiOperationsResponse
        {
            [JsonPropertyName("operations")]
            public Dictionary<string, ApiOperationDefinition> Operations { get; set; }

            [JsonPropertyName("metaData")]
            public OperationMetaData? MetaData { get; set; }
        }

        public class ApiOperationDefinition
        {
            [JsonPropertyName("contentType")]
            public string? ContentType { get; set; }

            [JsonPropertyName("expectedStatusCodes")]
            public List<int> ExpectedStatusCodes { get; set; }

            [JsonPropertyName("longRunning")]
            public bool LongRunning { get; set; }

            [JsonPropertyName("method")]
            public string Method { get; set; }

            [JsonPropertyName("requestObject")]
            public ApiObjectDefinition? RequestObject { get; set; }

            [JsonPropertyName("resourceIdName")]
            public string? ResourceIdName { get; set; }

            [JsonPropertyName("responseObject")]
            public ApiObjectDefinition? ResponseObject { get; set; }

            // ApiVersion specifies that a different API version should be used for
            // this than the Parent Service. Whilst bizarre, some Azure API's do this
            // rather than duplicating the API - which is unfortunate since it means
            // we have these mixed-version imports - but I digress.
            [JsonPropertyName("apiVersion")]
            public string? ApiVersion { get; set; }

            [JsonPropertyName("uriSuffix")]
            public string UriSuffix { get; set; }

            [JsonPropertyName("fieldContainingPaginationDetails")]
            public string FieldContainingPaginationDetails { get; set; }

            [JsonPropertyName("options")]
            public Dictionary<string, ApiOperationOption> Options { get; set; }
        }

        public class ApiOperationOption
        {
            // TODO: header name too
            [JsonPropertyName("queryStringName")]
            public string? QueryStringName { get; set; }

            [JsonPropertyName("objectDefinition")]
            public ApiObjectDefinition ObjectDefinition { get; set; }

            [JsonPropertyName("required")]
            public bool Required { get; set; }
        }

        public class OperationMetaData
        {
            [JsonPropertyName("resourceProvider")]
            public string? ResourceProvider { get; set; }

            // TODO: API Availability Details (e.g. GA in Public, PrivatePreview in China?)
        }
    }
}