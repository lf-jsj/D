using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Converter;
using Snap.Data.Mapper.Model.ObjectModel;
using Snap.Data.Mapper.Model.ObjectModel.Converter;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Achievement;
using Snap.Data.Mapper.Pipeline.Avatar;
using Snap.Data.Mapper.Pipeline.Reliquary;
using Snap.Data.Mapper.TextMapping;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Snap.Data.Mapper;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mapper Started.");
        Console.WriteLine("Please input GenshinData Folder Path:");

        if (Console.ReadLine() is string genshinDataFolder)
        {
            Console.WriteLine("Please input Output Folder Path:");

            if (Console.ReadLine() is string outputFolder)
            {
                ITextMap textMap = new TextMap(Path.Combine(genshinDataFolder, "TextMap", "TextMapCHS.json"));
                TextMapHashConverter textMapHashConverter = new(textMap);

                JsonSerializerOptions options = JsonContext.CreateDefaultOption();
                options.Converters.Add(textMapHashConverter);
                options.Converters.Add(new HashPreConverter());
                options.Converters.Add(new HashSuffixConverter());

                Stopwatch stopwatch = Stopwatch.StartNew();

                RunPipeLine<AchievementPipeline>(genshinDataFolder, outputFolder, options, stopwatch);
                RunPipeLine<AvatarPipeline>(genshinDataFolder, outputFolder, options, stopwatch);
                RunPipeLine<ReliquaryPipeline>(genshinDataFolder, outputFolder, options, stopwatch);

                Console.WriteLine("All Pipelines Completed.");
            }
        }
    }

    public static void RunPipeLine<TPipeline>(string genshinDataFolder, string outputFolder, JsonSerializerOptions options, Stopwatch stopwatch)
        where TPipeline : IPipeline, new()
    {
        string typeName = typeof(TPipeline).Name;
        Console.WriteLine("Running {0}...", typeName);
        new TPipeline().Run(genshinDataFolder, outputFolder, options);
        Console.WriteLine("{0} Run to completion in {1} ms.", typeName, stopwatch.ElapsedMilliseconds);
        stopwatch.Restart();
    }
}
