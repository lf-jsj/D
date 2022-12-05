﻿namespace Snap.Data.Mapper.Model.Common.Curve;

public class TypeGrowCurve : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("growCurve")]
    public string GrowCurve { get; set; } = default!;
}

public class FightPropertyTypeGrowCurve : DataObject
{
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public FightProperty Type { get; set; } = default!;

    [JsonPropertyName("growCurve")]
    public int GrowCurve { get; set; } = default!;
}