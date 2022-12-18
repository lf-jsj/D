using Snap.Data.Mapper.Model.ExcelBinOutput.Material;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Material;
internal class MaterialPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IEnumerable<MaterialExcelConfigData> data = IPipeline.GetData<MaterialExcelConfigData>(genshinDataFolder, options);
        IEnumerable<Material> result = data
            .Where(m => !string.IsNullOrEmpty(m.NameTextMapHash.Value))
            .Where(m => !string.IsNullOrEmpty(m.DescTextMapHash.Value))
            .Where(m => !string.IsNullOrEmpty(m.TypeDescTextMapHash.Value))
            .Where(m => !m.NameTextMapHash.Value.Contains("(test)"))
            .Where(m => !m.NameTextMapHash.Value.Contains("（废弃）"))
            .Where(m => m.Icon.StartsWith("UI_ItemIcon_"))
            .Select(m => new Material()
            {
                Id = m.Id,
                RankLevel = m.RankLevel,
                Name = m.NameTextMapHash.Value,
                Description = m.DescTextMapHash.Value.Replace(@"\n", "\n"),
                TypeDescription = m.TypeDescTextMapHash.Value,
                Icon = m.Icon,
                ItemType = m.ItemType,
            });

        IPipeline.GenerateFile<Material>(result, outputFolder, options);
    }
}