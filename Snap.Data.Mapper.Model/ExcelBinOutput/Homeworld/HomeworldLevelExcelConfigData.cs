namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeworldLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }

    [JsonPropertyName("comfortPointLimit")]
    public int ComfortPointLimit { get; set; }

    [JsonPropertyName("homeCoinStoreLimit")]
    public int HomeCoinStoreLimit { get; set; }

    [JsonPropertyName("homeFetterExpStoreLimit")]
    public int HomeFetterExpStoreLimit { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("furnitureMakeSlotCount")]
    public int FurnitureMakeSlotCount { get; set; }

    [JsonPropertyName("outdoorUnlockBlockCount")]
    public int OutdoorUnlockBlockCount { get; set; }

    [JsonPropertyName("freeUnlockModuleCount")]
    public int FreeUnlockModuleCount { get; set; }

    [JsonPropertyName("deployNpcCount")]
    public int DeployNpcCount { get; set; }

    [JsonPropertyName("djinnGadgetId")]
    public int DjinnGadgetId { get; set; }

    [JsonPropertyName("limitShopGoodsCount")]
    public int LimitShopGoodsCount { get; set; }

    [JsonPropertyName("levelFuncs")]
    public IList<string> LevelFuncs { get; set; } = default!;
}