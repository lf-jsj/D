namespace Snap.Data.Mapper.Model.ExcelBinOutput.Vehicle;

public class VehicleSkillExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("HJAAOLIHCMD")]
    public Text HJAAOLIHCMD { get; set; }

    [JsonPropertyName("PINPKNAJILI")]
    public Text PINPKNAJILI { get; set; }

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = default!;

    [JsonPropertyName("skillIcon")]
    public string SkillIcon { get; set; } = default!;

    [JsonPropertyName("GCICAFBONNB")]
    public double GCICAFBONNB { get; set; }

    [JsonPropertyName("GKLIEMDLFLM")]
    public int GKLIEMDLFLM { get; set; }

    [JsonPropertyName("lockShape")]
    public string LockShape { get; set; } = default!;

    [JsonPropertyName("lockWeightParams")]
    public IList<double> LockWeightParams { get; set; } = default!;
}