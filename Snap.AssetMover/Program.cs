namespace Snap.AssetMover;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mapper Started.");
        Console.WriteLine("Please input GenshinAsset Folder Path:");

        if (Console.ReadLine() is string assetFolder)
        {
            Console.WriteLine("Please input Static Folder Path:");

            if (Console.ReadLine() is string staticFolder)
            {
                Directory.CreateDirectory(Path.Combine(staticFolder, "Skill"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "AchievementIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "AvatarIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "ChapterIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "EmotionIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "EquipIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "GachaAvatarIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "GachaAvatarImg"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "GachaEquipIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "IconElement"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "ItemIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "LoadingPic"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "MonsterIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "MonsterSmallIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "NameCardIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "NameCardPic"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "RelicIcon"));
                Directory.CreateDirectory(Path.Combine(staticFolder, "Talent"));

                foreach (string file in Directory.GetFiles(assetFolder))
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.StartsWith("Skill_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "Skill", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_AchievementIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "AchievementIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_AvatarIcon_") && (!fileName.Contains("_Card")) /*&& (!fileName.Contains("Costume"))*/)
                    {
                        File.Copy(file, Path.Combine(staticFolder, "AvatarIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_ChapterIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "ChapterIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_EmotionIcon"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "EmotionIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_EquipIcon"))
                    {
                        string iconFile = Path.Combine(staticFolder, "EquipIcon", TrimBlkName(fileName));
                        if (!File.Exists(iconFile))
                        {
                            File.Copy(file, iconFile, false);
                        }
                        continue;
                    }

                    if (fileName.StartsWith("UI_Gacha_AvatarIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "GachaAvatarIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_Gacha_AvatarImg_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "GachaAvatarImg", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_Gacha_EquipIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "GachaEquipIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_Icon_Element_"))
                    {
                        string iconFile = Path.Combine(staticFolder, "IconElement", TrimBlkName(fileName));
                        if (!File.Exists(iconFile))
                        {
                            File.Copy(file, iconFile, false);
                        }
                        continue;
                    }

                    if (fileName.StartsWith("UI_ItemIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "ItemIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_LoadingPic_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "LoadingPic", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_MonsterIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "MonsterIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_MonsterSmallIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "MonsterSmallIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_NameCardIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "NameCardIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_NameCardPic_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "NameCardPic", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_QUALITY_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "Bg", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_RelicIcon_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "RelicIcon", TrimBlkName(fileName)), true);
                        continue;
                    }

                    if (fileName.StartsWith("UI_Talent_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "Talent", TrimBlkName(fileName)), true);
                        continue;
                    }
                }
            }
        }
    }

    public static string TrimBlkName(string source)
    {
        string[] result = source.Split('+', '.');
        return $"{result[0]}.{result[2]}";
    }
}
