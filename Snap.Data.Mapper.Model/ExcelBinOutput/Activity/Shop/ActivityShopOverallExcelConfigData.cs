namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Shop;

public class ActivityShopOverallExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;

    [JsonPropertyName("sheetList")]
    public IList<int> SheetList { get; set; } = default!;
}