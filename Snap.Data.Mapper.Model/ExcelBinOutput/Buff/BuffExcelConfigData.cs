namespace Snap.Data.Mapper.Model.ExcelBinOutput.Buff;
public class BuffExcelConfigData : DataObject
{
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("desc")]
    public string Desc { get; set; } = default!;

    [JsonPropertyName("time")]
    public double Time { get; set; }

    [JsonPropertyName("isPersistent")]
    public bool IsPersistent { get; set; }

    [JsonPropertyName("serverBuffId")]
    public int ServerBuffId { get; set; }

    [JsonPropertyName("serverBuffType")]
    public string ServerBuffType { get; set; } = default!;

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = default!;

    [JsonPropertyName("modifierName")]
    public string ModifierName { get; set; } = default!;

    [JsonPropertyName("BKMJLJFLCBN")]
    public bool? BKMJLJFLCBN { get; set; }

    [JsonPropertyName("stackType")]
    public string StackType { get; set; } = default!;
}
