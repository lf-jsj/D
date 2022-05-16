namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderFormulaExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("BOENDAGDFCI")]
    public IList<CountableItem> BOENDAGDFCI { get; set; } = default!;

    [JsonPropertyName("OJLPCCLKHLJ")]
    public IList<CountableItem> OJLPCCLKHLJ { get; set; } = default!;

    [JsonPropertyName("AJJNCNNHCEA")]
    public IList<int> AJJNCNNHCEA { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("BOEMFGBHLNM")]
    public int BOEMFGBHLNM { get; set; }

    [JsonPropertyName("PNEGLDIHCKM")]
    public int PNEGLDIHCKM { get; set; }

    [JsonPropertyName("IJDJJIGPOKH")]
    public Text IJDJJIGPOKH { get; set; }

    [JsonPropertyName("AGBCHACBGFH")]
    public string AGBCHACBGFH { get; set; } = default!;
}
