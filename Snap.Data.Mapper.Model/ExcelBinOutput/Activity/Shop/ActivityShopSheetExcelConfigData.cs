using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Shop;

public class ActivityShopSheetExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("isAheadPreview")]
    public bool IsAheadPreview { get; set; }

    [JsonPropertyName("SheetNameTextMapHash")]
    public Text SheetNameTextMapHash { get; set; }

    [JsonPropertyName("cond")]
    public IList<TypeParam<int>> Cond { get; set; } = default!;

    [JsonPropertyName("sortLevel")]
    public IList<DataObject> SortLevel { get; set; } = default!;
}
