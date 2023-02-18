namespace Snap.AssetMover;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("AssetMover Started.");
        Console.WriteLine("Please input GenshinAsset Folder Path:");

        if (Console.ReadLine() is string assetFolder)
        {
            Console.WriteLine("Please input Static Folder Path:");

            if (Console.ReadLine() is string staticFolder)
            {
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "Skill")); // Skill_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "AchievementIcon")); // UI_AchievementIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "AvatarIcon")); // UI_AvatarIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "AvatarCard")); // UI_AvatarIcon_ _Card
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "Costume")); // UI_Costume_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "ChapterIcon")); // UI_ChapterIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "EmotionIcon")); // UI_EmotionIcon
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "EquipIcon")); // UI_EquipIcon
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "GachaAvatarIcon")); // UI_Gacha_AvatarIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "GachaAvatarImg")); // UI_Gacha_AvatarImg_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "GachaEquipIcon")); // UI_Gacha_EquipIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "GcgCardFace")); // UI_Gcg_CardFace_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "IconElement")); // UI_Icon_Element_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "ItemIcon")); // UI_ItemIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "LoadingPic")); // UI_LoadingPic_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "MonsterIcon")); // UI_MonsterIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "MonsterSmallIcon")); // UI_MonsterSmallIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "NameCardIcon")); // UI_NameCardIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "NameCardPic")); // UI_NameCardPic_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "RelicIcon")); // UI_RelicIcon_
                _ = Directory.CreateDirectory(Path.Combine(staticFolder, "Talent")); // UI_Talent_

                foreach (string file in Directory.EnumerateFiles(assetFolder, "*.png", SearchOption.AllDirectories))
                {
                    string fileName = Path.GetFileName(file);

                    if (fileName.StartsWith("UI_QUALITY_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "Bg", TrimBlkName(fileName)), true);
                        continue;
                    }

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

                    if (fileName.StartsWith("UI_AvatarIcon_"))
                    {
                        if (fileName.Contains("_Card"))
                        {
                            File.Copy(file, Path.Combine(staticFolder, "AvatarCard", TrimBlkName(fileName)), true);
                            continue;
                        }
                        else
                        {
                            File.Copy(file, Path.Combine(staticFolder, "AvatarIcon", TrimBlkName(fileName)), true);
                            continue;
                        }
                    }

                    if (fileName.StartsWith("UI_Costume_"))
                    {
                        File.Copy(file, Path.Combine(staticFolder, "Costume", TrimBlkName(fileName)), true);
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
                        File.Copy(file, Path.Combine(staticFolder, "EquipIcon", TrimBlkName(fileName)), true);
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
                        File.Copy(file, Path.Combine(staticFolder, "IconElement", TrimBlkName(fileName)), true);
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
