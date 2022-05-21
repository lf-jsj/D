using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicBuildingExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("specialEffectLevel1")]
    public int SpecialEffectLevel1 { get; set; }

    [JsonPropertyName("specialEffectLevel2")]
    public int SpecialEffectLevel2 { get; set; }

    [JsonPropertyName("specialEffectDesc1TextMapHash")]
    public Text SpecialEffectDesc1TextMapHash { get; set; }

    [JsonPropertyName("specialEffectDesc2TextMapHash")]
    public Text SpecialEffectDesc2TextMapHash { get; set; }

    [JsonPropertyName("maxLevel")]
    public int MaxLevel { get; set; }

    [JsonPropertyName("openConds")]
    public IList<KeyValue> OpenConds { get; set; } = default!;

    [JsonPropertyName("defaultDungeonList")]
    public IList<int> DefaultDungeonList { get; set; } = default!;

    [JsonPropertyName("elementType")]
    public int ElementType { get; set; }

    [JsonPropertyName("isEnableRotate")]
    public bool? IsEnableRotate { get; set; }

    [JsonPropertyName("buildLimit")]
    public int? BuildLimit { get; set; }
}
