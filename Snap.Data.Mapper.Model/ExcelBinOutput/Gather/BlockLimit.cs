﻿namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gather;

public class BlockLimit : DataObject
{
    [JsonPropertyName("blockId")]
    public int BlockId { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}
