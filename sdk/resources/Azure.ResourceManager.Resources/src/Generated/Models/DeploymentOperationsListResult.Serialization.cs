// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentOperationsListResult
    {
        internal static DeploymentOperationsListResult DeserializeDeploymentOperationsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeploymentOperation>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeploymentOperation> array = new List<DeploymentOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentOperation.DeserializeDeploymentOperation(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DeploymentOperationsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
