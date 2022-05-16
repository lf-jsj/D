namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;
public class HomeworldAnimalExcelConfigData : DataObject
{
    [JsonPropertyName("furnitureID")]
    public int FurnitureID { get; set; }

    [JsonPropertyName("monsterID")]
    public int MonsterID { get; set; }

    [JsonPropertyName("isRebirth")]
    public int IsRebirth { get; set; }

    [JsonPropertyName("rebirthCD")]
    public int RebirthCD { get; set; }
}
