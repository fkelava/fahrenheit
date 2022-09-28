using System;

namespace Fahrenheit.Common.WorldMap;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class FhCapabilityMarkerAttribute : Attribute
{
    public bool DEditCapable { get; init; }
}