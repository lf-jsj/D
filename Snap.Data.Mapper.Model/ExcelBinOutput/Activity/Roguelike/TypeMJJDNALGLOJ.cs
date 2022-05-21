namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class TypeMJJDNALGLOJ : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("MJJDNALGLOJ")]
    public IList<int> MJJDNALGLOJ { get; set; } = default!;
}
