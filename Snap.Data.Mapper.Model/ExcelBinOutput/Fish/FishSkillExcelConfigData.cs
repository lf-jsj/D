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
    public IList<double> Param { get; set; } = default!;

    [JsonPropertyName("NALKLOJDGGI")]
    public double NALKLOJDGGI { get; set; }

    [JsonPropertyName("OBCDGCHGPHF")]
    public IList<double> OBCDGCHGPHF { get; set; } = default!;

    [JsonPropertyName("GBALIGDIKKA")]
    public IList<double> GBALIGDIKKA { get; set; } = default!;

    [JsonPropertyName("MLHKPEPCIMJ")]
    public IList<int> MLHKPEPCIMJ { get; set; } = default!;

    [JsonPropertyName("ADAIFFEOELG")]
    public IList<double> ADAIFFEOELG { get; set; } = default!;

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("MAIGFCKBNOM")]
    public int? MAIGFCKBNOM { get; set; }
}
