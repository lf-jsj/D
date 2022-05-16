namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetInteractExcelConfigData : DataObject
{
    [JsonPropertyName("interactId")]
    public int InteractId { get; set; }

    [JsonPropertyName("actionType")]
    public string ActionType { get; set; } = default!;

    [JsonPropertyName("param1")]
    public int Param1 { get; set; }

    [JsonPropertyName("IAOBLJPMBFJ")]
    public IList<IAOBLJPMBFJ> IAOBLJPMBFJ { get; set; } = default!;

    [JsonPropertyName("costItems")]
    public IList<CountableItem> CostItems { get; set; } = default!;

    [JsonPropertyName("uiTitleTextMapHash")]
    public Text UiTitleTextMapHash { get; set; }

    [JsonPropertyName("uiDescTextMapHash")]
    public Text UiDescTextMapHash { get; set; }

    [JsonPropertyName("condList")]
    public IList<ParamCondType> CondList { get; set; } = default!;

    [JsonPropertyName("consumeItemNum")]
    public bool ConsumeItemNum { get; set; }

    [JsonPropertyName("consumeItemId")]
    public bool? ConsumeItemId { get; set; }
}
