namespace Snap.Data.Mapper.Model.ExcelBinOutput.Element;

public class ElementStateExcelConfigData : DataObject
{

    /// <summary>
    /// Examples: "Fire", "Water", "Grass", "Electric", "Wind"
    /// </summary>
    [JsonPropertyName("elementType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ElementType ElementType { get; set; }

    /// <summary>
    /// Examples: "UI_Buff_Element_Fire", "UI_Buff_Element_Water", "UI_Buff_Element_Grass", "UI_Buff_Element_Elect", "UI_Buff_Element_Wind"
    /// </summary>
    [JsonPropertyName("elementIcon")]
    public string ElementIcon { get; set; }

    /// <summary>
    /// Examples: 1, 2, 3, 4, 5
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
}