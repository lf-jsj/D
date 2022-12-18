namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishSkillExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("skillCategory")]
    public string SkillCategory { get; set; } = default!;

    [JsonPropertyName("HCIOELGLGGO")]
    public string HCIOELGLGGO { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<float> Param { get; set; } = default!;

    [JsonPropertyName("NALKLOJDGGI")]
    public float NALKLOJDGGI { get; set; }

    [JsonPropertyName("OBCDGCHGPHF")]
    public IList<float> OBCDGCHGPHF { get; set; } = default!;

    [JsonPropertyName("GBALIGDIKKA")]
    public IList<float> GBALIGDIKKA { get; set; } = default!;

    [JsonPropertyName("MLHKPEPCIMJ")]
    public IList<int> MLHKPEPCIMJ { get; set; } = default!;

    [JsonPropertyName("ADAIFFEOELG")]
    public IList<float> ADAIFFEOELG { get; set; } = default!;

    [JsonPropertyName("duration")]
    public float Duration { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("MAIGFCKBNOM")]
    public int? MAIGFCKBNOM { get; set; }
}
