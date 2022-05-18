namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MusicGame;

public class ComboConfig : DataObject
{
    [JsonPropertyName("comboUpLimit")]
    public int ComboUpLimit { get; set; }

    [JsonPropertyName("rate")]
    public double Rate { get; set; }
}
