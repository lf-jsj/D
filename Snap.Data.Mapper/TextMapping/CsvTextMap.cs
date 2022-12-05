// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Data.Mapper.Abstraction;
using System.Collections.Generic;
using System.IO;

namespace Snap.Data.Mapper.TextMapping;

internal class CsvTextMap : ITextMap
{
    private readonly Dictionary<string, string> textMapping = new();

    public CsvTextMap(string folderPath)
    {
        foreach(string csvFile in Directory.GetFiles(folderPath))
        {
            using (StreamReader reader = new(csvFile))
            {
                while(!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] segments = line.Split(',', 2);
                        textMapping[segments[0]] = segments[1];
                    }
                }
            }
        }
    }

    public string? this[string? key] { get => key != null && textMapping.TryGetValue(key, out string? result) ? result : null; }
}