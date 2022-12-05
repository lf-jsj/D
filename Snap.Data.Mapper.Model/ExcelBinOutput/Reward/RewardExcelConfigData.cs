using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
public class RewardExcelConfigData : IndexableDataObject
{
    public int RewardId { get; set; }

    public IList<ItemIdItemCount> RewardItemList { get; set; } = default!;

    public int Scoin { get; set; }

    public int PlayerExp { get; set; }

    public int Hcoin { get; set; }

    public override int GetIndex()
    {
        return RewardId;
    }
}