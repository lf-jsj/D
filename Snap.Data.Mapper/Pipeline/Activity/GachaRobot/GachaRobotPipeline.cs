using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Gacha;
using Snap.Data.Mapper.Model.ExcelBinOutput.Material;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Activity.GachaRobot;

internal class GachaRobotPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IEnumerable<ActivityGachaRobotExcelConfigData> gachaRobots = IPipeline
            .GetData<ActivityGachaRobotExcelConfigData>(genshinDataFolder, options);

        IEnumerable<MaterialExcelConfigData> materials = IPipeline
            .GetData<MaterialExcelConfigData>(genshinDataFolder, options);

        List<GachaRobot> resultCache = new();

        foreach(ActivityGachaRobotExcelConfigData robot in gachaRobots)
        {
            GachaRobot result = new()
            {
                Type = robot.Type,
                Name = materials.First(x => x.Id == robot.MaterialId).NameTextMapHash.Value,
                Model = robot.ModelPath,
                Description = robot.DescTextMapHash.Value,
            };

            resultCache.Add(result);
        }

        IPipeline.GenerateFile<GachaRobot>(resultCache, outputFolder, options);
    }

    private class GachaRobot
    {
        public string Type { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
