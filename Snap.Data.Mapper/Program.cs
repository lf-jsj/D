using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Converter;
using Snap.Data.Mapper.Core;
using Snap.Data.Mapper.Model.ObjectModel;
using Snap.Data.Mapper.Model.ObjectModel.Converter;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Achievement;
using Snap.Data.Mapper.Pipeline.Avatar;
using Snap.Data.Mapper.Pipeline.Reliquary;
using Snap.Data.Mapper.Pipeline.Weapon;
using Snap.Data.Mapper.TextMapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
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

                RunPipeLine<AchievementPipeline>(genshinDataFolder, outputFolder, options);
                RunPipeLine<AvatarPipeline>(genshinDataFolder, outputFolder, options);
                RunPipeLine<ReliquaryPipeline>(genshinDataFolder, outputFolder, options);
                RunPipeLine<WeaponPipeline>(genshinDataFolder, outputFolder, options);

                Console.WriteLine("All Pipelines Completed.");

                GenerateMetaMd5(outputFolder, options);

                Console.WriteLine("MD5 Generation Completed.");

                //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                //RunPipeLine<GachaRobotPipeline>(genshinDataFolder, desktop, options, stopwatch);

                //Console.WriteLine("Extra Stuff Completed.");
            }
        }
    }

    private static void RunPipeLine<TPipeline>(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
        where TPipeline : IPipeline, new()
    {
        ValueStopwatch stopwatch = ValueStopwatch.StartNew();
        string typeName = typeof(TPipeline).Name;
        Console.WriteLine("Running {0}...", typeName);
        new TPipeline().Run(genshinDataFolder, outputFolder, options);
        Console.WriteLine("{0} Run to completion in {1} ms.", typeName, stopwatch.GetElapsedTime().Milliseconds);
    }

    private static void GenerateMetaMd5(string outputFolder, JsonSerializerOptions options)
    {
        Dictionary<string, string> meta = new();

        foreach (string fileName in Directory.EnumerateFiles(outputFolder!, "*.json", SearchOption.AllDirectories))
        {
            string name = Path.GetFileNameWithoutExtension(fileName);

            if(name == "Meta")
            {
                continue;
            }

            // get md5
            using (FileStream file = new(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                MD5 md5 = MD5.Create();
                byte[] computedByts = md5.ComputeHash(file);
                string check = Convert.ToHexString(computedByts);

                meta.Add(name, check);
            }
        }

        using (FileStream outStream = File.Create(Path.Combine(outputFolder, "Meta.json")))
        {
            JsonSerializer.Serialize(outStream, meta, options);
        }
    }
}
