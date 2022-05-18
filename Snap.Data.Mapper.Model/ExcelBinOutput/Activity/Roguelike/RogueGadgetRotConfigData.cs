namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueGadgetRotConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("HIAJFDCNIPC")]
    public int HIAJFDCNIPC { get; set; }

    [JsonPropertyName("NKCEDFOPMEL")]
    public string NKCEDFOPMEL { get; set; } = default!;
}