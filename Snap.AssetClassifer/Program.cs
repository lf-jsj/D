namespace Snap.AssetClassifer;

internal class Program
{
    private static HashSet<string> subFolders = new();
    static void Main(string[] args)
    {
        Console.WriteLine("Texture2D Classifier Started.");
        Console.WriteLine("Please input Texture2D Folder Path:");

        if (Console.ReadLine() is string assetFolder)
        {
            foreach (string file in Directory.GetFiles(assetFolder))
            {
                string baseDir = Path.GetDirectoryName(file)!;
                string fileName = Path.GetFileName(file);

                if (fileName.StartsWith("Background+")
                    || fileName.StartsWith("Default-Particle+")
                    || fileName.StartsWith("UIMask+")
                    || fileName.StartsWith("UISprite+")
                    || fileName.StartsWith("White+"))
                {
                    File.Delete(file);
                    continue;
                }

                int dashIndex = fileName.IndexOf('_');
                if (dashIndex > 0)
                {
                    string folder = fileName[..dashIndex];
                    if(!subFolders.Contains(folder))
                    {
                        _ = Directory.CreateDirectory(Path.Combine(baseDir, folder));
                        _ = subFolders.Add(folder);
                    }

                    File.Move(file, Path.Combine(baseDir, folder, fileName));
                }
            }
        }
    }
}
