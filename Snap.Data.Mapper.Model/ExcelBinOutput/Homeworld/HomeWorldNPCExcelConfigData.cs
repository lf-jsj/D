namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldNPCExcelConfigData : DataObject
{
    [JsonPropertyName("furnitureID")]
    public int FurnitureID { get; set; }

    [JsonPropertyName("avatarID")]
    public int AvatarID { get; set; }

    [JsonPropertyName("LMNMJEOFJNC")]
    public int LMNMJEOFJNC { get; set; }

    [JsonPropertyName("OGFMOOMMFDO")]
    public IList<int> OGFMOOMMFDO { get; set; } = default!;

    [JsonPropertyName("CPAJDIAKOHO")]
    public string CPAJDIAKOHO { get; set; } = default!;

    [JsonPropertyName("CNMCIIOEJJI")]
    public string CNMCIIOEJJI { get; set; } = default!;

    [JsonPropertyName("EAAFILMAFOH")]
    public string EAAFILMAFOH { get; set; } = default!;

    [JsonPropertyName("CHHGFLJPHPG")]
    public Text CHHGFLJPHPG { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("MFACINAFDKL")]
    public bool? MFACINAFDKL { get; set; }

    [JsonPropertyName("KIJFJEEDJDJ")]
    public string KIJFJEEDJDJ { get; set; } = default!;
}
