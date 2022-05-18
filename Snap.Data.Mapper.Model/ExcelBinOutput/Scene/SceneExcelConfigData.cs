namespace Snap.Data.Mapper.Model.ExcelBinOutput.Scene;
public class SceneExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("scriptData")]
    public string ScriptData { get; set; } = default!;

    [JsonPropertyName("overrideDefaultProfile")]
    public string OverrideDefaultProfile { get; set; } = default!;

    [JsonPropertyName("levelEntityConfig")]
    public string LevelEntityConfig { get; set; } = default!;

    [JsonPropertyName("specifiedAvatarList")]
    public IList<int> SpecifiedAvatarList { get; set; } = default!;

    [JsonPropertyName("comment")]
    public string Comment { get; set; } = default!;

    [JsonPropertyName("HPHMCOMLMPN")]
    public bool? HPHMCOMLMPN { get; set; }

    [JsonPropertyName("maxSpecifiedAvatarNum")]
    public int? MaxSpecifiedAvatarNum { get; set; }

    [JsonPropertyName("HAFOGPLLBFH")]
    public string HAFOGPLLBFH { get; set; } = default!;

    [JsonPropertyName("PKJNCEAIFFB")]
    public int? PKJNCEAIFFB { get; set; }

    [JsonPropertyName("IGEIMMEHIDG")]
    public bool? IGEIMMEHIDG { get; set; }

    [JsonPropertyName("OGPODEBAOKA")]
    public bool? OGPODEBAOKA { get; set; }

    [JsonPropertyName("KHOHJOLLACG")]
    public double? KHOHJOLLACG { get; set; }

    [JsonPropertyName("entityAppearSorted")]
    public int? EntityAppearSorted { get; set; }
}