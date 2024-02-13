// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

package resourceids

import (
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

var _ commonIdMatcher = commonIdSqlElasticPool{}

type commonIdSqlElasticPool struct{}

func (c commonIdSqlElasticPool) id() models.ParsedResourceId {
	name := "SqlElasticPool"
	return models.ParsedResourceId{
		CommonAlias: &name,
		Constants:   map[string]resourcemanager.ConstantDetails{},
		Segments: []resourcemanager.ResourceIdSegment{
			models.StaticResourceIDSegment("subscriptions", "subscriptions"),
			models.SubscriptionIDResourceIDSegment("subscriptionId"),
			models.StaticResourceIDSegment("resourceGroups", "resourceGroups"),
			models.ResourceGroupResourceIDSegment("resourceGroupName"),
			models.StaticResourceIDSegment("providers", "providers"),
			models.ResourceProviderResourceIDSegment("resourceProvider", "Microsoft.Sql"),
			models.StaticResourceIDSegment("servers", "servers"),
			models.UserSpecifiedResourceIDSegment("serverName"),
			models.StaticResourceIDSegment("elasticPools", "elasticPools"),
			models.UserSpecifiedResourceIDSegment("elasticPoolName"),
		},
	}
}
