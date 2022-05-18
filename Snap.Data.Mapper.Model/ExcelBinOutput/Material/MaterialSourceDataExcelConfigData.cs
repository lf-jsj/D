namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class MaterialSourceDataExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonList")]
    public IList<int> DungeonList { get; set; } = default!;

    [JsonPropertyName("FCMLHLEGJLL")]
    public IList<FCMLHLEGJLL> FCMLHLEGJLL { get; set; } = default!;

    [JsonPropertyName("MPHEPLJKAIB")]
    public IList<int> MPHEPLJKAIB { get; set; } = default!;

    [JsonPropertyName("IKOFKNICMDA")]
    public IList<string> IKOFKNICMDA { get; set; } = default!;

    [JsonPropertyName("NEFNMBLFPPB")]
    public IList<int> NEFNMBLFPPB { get; set; } = default!;

    [JsonPropertyName("jumpList")]
    public IList<Text> JumpList { get; set; } = default!;

    [JsonPropertyName("textList")]
    public IList<Text> TextList { get; set; } = default!;
}