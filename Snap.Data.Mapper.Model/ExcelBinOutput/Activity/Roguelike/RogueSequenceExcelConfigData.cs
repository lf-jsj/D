namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueSequenceExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("PJEKPGKOJNA")]
    public int PJEKPGKOJNA { get; set; }

    [JsonPropertyName("LEAELDOHCFI")]
    public IList<int> LEAELDOHCFI { get; set; } = default!;

    [JsonPropertyName("HFHJLLEIGHK")]
    public HFHJLLEIGHK HFHJLLEIGHK { get; set; } = default!;

    [JsonPropertyName("PGAJLDPJLIO")]
    public IList<TypeMJJDNALGLOJ> PGAJLDPJLIO { get; set; } = default!;
}