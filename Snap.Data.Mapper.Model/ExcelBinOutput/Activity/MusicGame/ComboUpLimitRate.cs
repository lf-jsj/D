﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MusicGame;

public class ComboUpLimitRate : DataObject
{
    [JsonPropertyName("comboUpLimit")]
    public int ComboUpLimit { get; set; }

    [JsonPropertyName("rate")]
    public float Rate { get; set; }
}
