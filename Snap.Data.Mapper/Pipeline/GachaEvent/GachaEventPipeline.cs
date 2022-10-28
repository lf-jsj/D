using Snap.Data.Mapper.Pipeline.Abstraction;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.GachaEvent;
internal class GachaEventPipeline : IPipeline
{
    private static readonly TimeSpan UTC8 = TimeSpan.FromHours(8);

    private readonly List<GachaEvent> gachaEvents = new()
    {
        // 1.0 上半
        new("1.0", "杯装之诗",GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "温迪" },
            UpPurpleList = new() { "芭芭拉", "菲谢尔", "香菱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/09/15/75276539/132d914791952d594e4cec135fb3ede3_4487838839007108236.png",
            From = new(2020, 9, 28, 6, 0, 0, UTC8),
            To = new(2020, 10, 18, 17, 59, 59, UTC8),
        },
        new("1.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "风鹰剑", "阿莫斯之弓" },
            UpPurpleList = new() { "笛剑", "流浪乐章", "钟剑", "绝弦", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/09/15/75276539/4d24326873976c7ccc0345e7aeab8c37_4144090565455150201.jpeg",
            From = new(2020, 9, 28, 6, 0, 0, UTC8),
            To = new(2020, 10, 18, 17, 59, 59, UTC8)
        },

        // 1.0 下半
        new("1.0","闪焰的驻足", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "可莉" },
            UpPurpleList = new() { "行秋", "诺艾尔", "砂糖" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/10/18/75276539/ef0588dbb693c4a0424e9c2682223d30_764153596931211235.jpeg",
            From = new(2020, 10, 20, 18, 0, 0, UTC8),
            To = new(2020, 11, 10, 14, 59, 59, UTC8)
        },
        new("1.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "狼的末路" },
            UpPurpleList = new() { "祭礼剑", "祭礼残章", "祭礼大剑", "祭礼弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/10/18/75276539/f5ced7d8ae18564506f41b43dea24e0d_3747695314725486266.jpeg",
            From = new(2020, 10, 20, 18, 0, 0, UTC8),
            To = new(2020, 11, 10, 14, 59, 59, UTC8)
        },

        // 1.1 上半
        new("1.1","暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpPurpleList = new() { "迪奥娜", "北斗", "凝光" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/11/09/75276539/0416df76c21e447dcc168908d227d25b_6361188051202916290.jpg",
            From = new(2020, 11, 11, 6, 0, 0, UTC8),
            To = new(2020, 12, 1, 15, 59, 59, UTC8)
        },
        new("1.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "天空之翼" },
            UpPurpleList = new() { "笛剑", "昭心", "雨裁", "弓藏", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/11/09/75276539/da3c58c77419b2b5a6aa4e8ace8645d4_5910366304389838288.jpg",
            From = new(2020, 11, 11, 6, 0, 0, UTC8),
            To = new(2020, 12, 1, 15, 59, 59, UTC8)
        },

        // 1.1 下半
        new("1.1","陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpPurpleList = new() { "辛焱", "雷泽", "重云" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/11/29/75276539/b256e1dc0124fba2de99d6b02e77b9e3_8645367221710274088.jpg",
            From = new(2020, 12, 1, 18, 0, 0, UTC8),
            To = new(2020, 12, 22, 14, 59, 59, UTC8)
        },
        new("1.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "无工之剑", "贯虹之槊" },
            UpPurpleList = new() { "匣里龙吟", "西风秘典", "钟剑", "西风猎弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/11/29/75276539/db78a0078d5880fd17ab877f6ee62974_7939420269943244699.jpg",
            From = new(2020, 12, 1, 18, 0, 0, UTC8),
            To = new(2020, 12, 22, 14, 59, 59, UTC8)
        },

        // 1.2 上半
        new("1.2","深秘之息", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "阿贝多" },
            UpPurpleList = new() { "菲谢尔", "砂糖", "班尼特" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/12/21/75276539/bb014c9058d033262daad04020ec6655_3588388033975268622.jpg",
            From = new(2020, 12, 23, 6, 0, 0, UTC8),
            To = new(2021, 1, 12, 15, 59, 59, UTC8)
        },
        new("1.2","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "天空之卷" },
            UpPurpleList = new() { "西风剑", "祭礼残章", "西风大剑", "绝弦", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2020/12/21/75276539/6b5e70029ad3eeab854b4156d29fa95f_738974110640424193.jpg",
            From = new(2020, 12, 23, 6, 0, 0, UTC8),
            To = new(2021, 1, 12, 15, 59, 59, UTC8)
        },

        // 1.2 下半
        new("1.2","浮生孰来", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "甘雨" },
            UpPurpleList = new() { "香菱", "行秋", "诺艾尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/01/08/75276539/ac12b49a80780c7b47259d868cb8678a_6408702842713596613.jpg",
            From = new(2021, 1, 12, 18, 0, 0, UTC8),
            To = new(2021, 2, 2, 14, 59, 59, UTC8)
        },
        new("1.2","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之傲", "阿莫斯之弓" },
            UpPurpleList = new() { "祭礼剑", "昭心", "钟剑", "西风猎弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/01/08/75276539/8674a5f8ad97619fc12b0ccd44e27913_5464020659785391830.jpg",
            From = new(2021, 1, 12, 18, 0, 0, UTC8),
            To = new(2021, 2, 2, 14, 59, 59, UTC8)
        },

        // 1.3 上半
        new("1.3","烟火之邀", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "魈" },
            UpPurpleList = new() { "迪奥娜", "北斗", "辛焱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/01/29/75276539/6b31fb8e0f3c28daeb46497181e82396_3299650758828039790.png",
            From = new(2021, 2, 3, 6, 0, 0, UTC8),
            To = new(2021, 2, 17, 15, 59, 59, UTC8)
        },
        new("1.3","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "和璞鸢" },
            UpPurpleList = new() { "笛剑", "昭心", "祭礼大剑", "弓藏", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/01/29/75276539/8651f3b2187a8326ffb949800778c887_5818658249793145129.png",
            From = new(2021, 2, 3, 6, 0, 0, UTC8),
            To = new(2021, 2, 23, 15, 59, 59, UTC8)
        },

        // 1.3 中场
        new("1.3","鱼龙灯昼", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "刻晴" },
            UpPurpleList = new() { "凝光", "班尼特", "芭芭拉" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/01/29/75276539/3f1768b16f6015e827500b3e7722e7b0_7155708829863422947.png",
            From = new(2021, 2, 17, 18, 0, 0, UTC8),
            To = new(2021, 3, 2, 15, 59, 59, UTC8)
        },

        // 1.3 下半
        new("1.3","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "狼的末路", "护摩之杖" },
            UpPurpleList = new() { "匣里龙吟", "流浪乐章", "千岩古剑", "祭礼弓", "千岩长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/02/20/75276539/2ae510694557728258e8a85014f1bb4f_5530944724515017704.png",
            From = new(2021, 2, 23, 18, 0, 0, UTC8),
            To = new(2021, 3, 16, 14, 59, 59, UTC8)
        },
        new("1.3","赤团开时", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "胡桃" },
            UpPurpleList = new() { "行秋", "香菱", "重云" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/02/26/75276539/51a0ed09702883625d094188b0f969f5_3511083345237270236.png",
            From = new(2021, 3, 2, 18, 0, 0, UTC8),
            To = new(2021, 3, 16, 14, 59, 59, UTC8)
        },

        // 1.4 上半
        new("1.4","杯装之诗", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "温迪" },
            UpPurpleList = new() { "砂糖", "雷泽", "诺艾尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/03/12/75276539/9a8bf4e4905885199e3fc5154233fa0f_553036799866234585.jpg",
            From = new(2021, 3, 17, 6, 0, 0, UTC8),
            To = new(2021, 4, 6, 15, 59, 59, UTC8)
        },
        new("1.4","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之刃", "终末嗟叹之诗" },
            UpPurpleList = new() { "暗巷闪光", "暗巷的酒与诗", "西风大剑", "西风猎弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/03/12/75276539/996df169fd2db1482a8f406eb35fc8a5_1694822233650156798.jpg",
            From = new(2021, 3, 17, 6, 0, 0, UTC8),
            To = new(2021, 4, 6, 15, 59, 59, UTC8)
        },

        // 1.4 下半
        new("1.4","暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpPurpleList = new() { "罗莎莉亚", "芭芭拉", "菲谢尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/03/29/75276539/d07924d52d25dc67bfb2884e707268b4_5052642728788010237.jpg",
            From = new(2021, 4, 6, 18, 0, 0, UTC8),
            To = new(2021, 4, 27, 14, 59, 59, UTC8)
        },
        new("1.4","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "天空之翼" },
            UpPurpleList = new() { "西风剑", "西风秘典", "祭礼大剑", "暗巷猎手", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/03/29/75276539/1d52bd0c966e9ff5cdabe6ac55fc22d7_3623078913072267651.jpg",
            From = new(2021, 4, 6, 18, 0, 0, UTC8),
            To = new(2021, 4, 27, 14, 59, 59, UTC8)
        },

        // 1.5 上半
        new("1.5","陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpPurpleList = new() { "烟绯", "诺艾尔", "迪奥娜" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/04/24/75276539/9c45c3b6dc8883fd4490b416d5dd345c_8845647751307081349.jpg",
            From = new(2021, 4, 28, 6, 0, 0, UTC8),
            To = new(2021, 5, 18, 17, 59, 59, UTC8)
        },
        new("1.5","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "尘世之锁" },
            UpPurpleList = new() { "笛剑", "昭心", "千岩古剑", "祭礼弓", "千岩长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/04/24/75276539/e9813e567f68e80731d390af43efd895_6128212326870731985.jpg",
            From = new(2021, 4, 28, 6, 0, 0, UTC8),
            To = new(2021, 5, 18, 17, 59, 59, UTC8)
        },

        // 1.5 下半
        new("1.5","浪涌之瞬", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "优菈" },
            UpPurpleList = new() { "辛焱", "行秋", "北斗" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/05/14/75276539/eb5c47f409e24adee5b34d3fff993bae_8676850712287137496.jpg",
            From = new(2021, 5, 18, 18, 0, 0, UTC8),
            To = new(2021, 6, 8, 14, 59, 59, UTC8)
        },
        new("1.5","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "风鹰剑", "松籁响起之时" },
            UpPurpleList = new() { "祭礼剑", "祭礼残章", "雨裁", "弓藏", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/05/14/75276539/16d7aeecd29f7b74cb5637ba43a00a74_6050238854430192446.jpg",
            From = new(2021, 5, 18, 18, 0, 0, UTC8),
            To = new(2021, 6, 8, 14, 59, 59, UTC8)
        },

        // 1.6 上半
        new("1.6","闪焰的驻足", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "可莉" },
            UpPurpleList = new() { "芭芭拉", "砂糖", "菲谢尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/06/04/75276539/428dd12c9a9a931c36a8a79339b10aee_4021802739575041815.png",
            From = new(2021, 6, 9, 6, 0, 0, UTC8),
            To = new(2021, 6, 29, 17, 59, 59, UTC8)
        },
        new("1.6","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "四风原典", "天空之傲" },
            UpPurpleList = new() { "匣里龙吟", "流浪乐章", "钟剑", "幽夜华尔兹", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/06/04/75276539/81f4e8ad59b58b116b0e5040a2c02a0d_6024992165913074581.png",
            From = new(2021, 6, 9, 6, 0, 0, UTC8),
            To = new(2021, 6, 29, 17, 59, 59, UTC8)
        },

        // 1.6 下半
        new("1.6","叶落风随", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "枫原万叶" },
            UpPurpleList = new() { "罗莎莉亚", "班尼特", "雷泽" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/06/25/75276539/23e532e2725f11f7b4122cbffbe66d00_1166425867060056584.png",
            From = new(2021, 6, 29, 18, 0, 0, UTC8),
            To = new(2021, 7, 20, 14, 59, 59, UTC8)
        },
        new("1.6","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "天空之卷" },
            UpPurpleList = new() { "暗巷闪光", "暗巷的酒与诗", "西风大剑", "暗巷猎手", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/06/25/75276539/4f19845337ba15c9ed3880dfb995dd84_360794397836889674.png",
            From = new(2021, 6, 29, 18, 0, 0, UTC8),
            To = new(2021, 7, 20, 14, 59, 59, UTC8)
        },

        // 2.0 上半
        new("2.0","白鹭之庭", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫华" },
            UpPurpleList = new() { "凝光", "重云", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/07/16/75276539/fc45ea8ba17397b0117049a842c8dbea_3303766097569245462.jpg",
            From = new(2021, 7, 21, 6, 0, 0, UTC8),
            To = new(2021, 8, 10, 17, 59, 59, UTC8)
        },
        new("2.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "雾切之回光", "天空之脊" },
            UpPurpleList = new() { "西风剑", "西风秘典", "祭礼大剑", "绝弦", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/07/16/75276539/a07c0133b356c2324acda0807c28ea93_6985660078871705520.jpg",
            From = new(2021, 7, 21, 6, 0, 0, UTC8),
            To = new(2021, 8, 10, 17, 59, 59, UTC8)
        },

        // 2.0 下半
        new("2.0","焰色天河", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "宵宫" },
            UpPurpleList = new() { "早柚", "迪奥娜", "辛焱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/08/06/75276539/f2a3385975fb003a6f9fe326f014cacf_7401135279852533087.jpg",
            From = new(2021, 8, 10, 18, 0, 0, UTC8),
            To = new(2021, 8, 31, 14, 59, 59, UTC8)
        },
        new("2.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "天空之刃", "飞雷之弦振" },
            UpPurpleList = new() { "祭礼剑", "祭礼残章", "雨裁", "西风猎弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/08/06/75276539/6e584852771fbd67128ab93957404456_6827625049705032846.jpg",
            From = new(2021, 8, 10, 18, 0, 0, UTC8),
            To = new(2021, 8, 31, 14, 59, 59, UTC8)
        },

        // 2.1 上半
        new("2.1","影寂天下人", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "雷电将军" },
            UpPurpleList = new() { "九条裟罗", "香菱", "砂糖" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/08/30/75276539/46109c138abe84cbf1d1e594ad0f11be_1276006035575662857.jpg",
            From = new(2021, 9, 1, 6, 0, 0, UTC8),
            To = new(2021, 9, 21, 17, 59, 59, UTC8)
        },
        new("2.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "无工之剑", "薙草之稻光" },
            UpPurpleList = new() { "匣里龙吟", "流浪乐章", "钟剑", "祭礼弓", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/08/30/75276539/1b976936535179d01e65f98764c5330e_2055324091120469017.jpg",
            From = new(2021, 9, 1, 6, 0, 0, UTC8),
            To = new(2021, 9, 21, 17, 59, 59, UTC8)
        },

        // 2.1 下半
        new("2.1","浮岳虹珠", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpPurpleList = new() { "罗莎莉亚", "北斗", "行秋" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/09/18/75276539/125851f7e5df55e2ba985a24eb12d2e9_8037661559211730686.jpg",
            From = new(2021, 9, 21, 18, 0, 0, UTC8),
            To = new(2021, 10, 12, 14, 59, 59, UTC8)
        },
        new("2.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "不灭月华" },
            UpPurpleList = new() { "笛剑", "西风秘典", "西风大剑", "绝弦", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/09/18/75276539/fc7589dfd0a1b1ca0322b5acf410d0c7_400474916180244736.jpg",
            From = new(2021, 9, 21, 18, 0, 0, UTC8),
            To = new(2021, 10, 12, 14, 59, 59, UTC8)
        },

        // 2.2 上半
        new("2.2","暂别冬都", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "达达利亚" },
            UpPurpleList = new() { "凝光", "重云", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/10/11/75276539/866578a8e9f3a574cf63c6f8165cc5fb_471963309413661162.jpg",
            From = new(2021, 10, 13, 6, 0, 0, UTC8),
            To = new(2021, 11, 2, 17, 59, 59, UTC8)
        },
        new("2.2","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "冬极白星" },
            UpPurpleList = new() { "西风剑", "昭心", "恶王丸", "弓藏", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/10/11/75276539/eb7350b592a1083615d943a0ca71a831_6960784009886778552.jpg",
            From = new(2021, 10, 13, 6, 0, 0, UTC8),
            To = new(2021, 11, 2, 17, 59, 59, UTC8)
        },

        // 2.2 下半
        new("2.2","赤团开时", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "胡桃" },
            UpPurpleList = new() { "托马", "迪奥娜", "早柚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/10/29/75276539/58f93aa54eeb06c327e159d1ed8b3bea_1303088191273586996.jpg",
            From = new(2021, 11, 2, 18, 0, 0, UTC8),
            To = new(2021, 11, 23, 14, 59, 59, UTC8)
        },
        new("2.2","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "终末嗟叹之诗", "护摩之杖" },
            UpPurpleList = new() { "祭礼剑", "流浪乐章", "雨裁", "曚云之月", "断浪长鳍" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/10/29/75276539/79e086c347f2aa5661faead6ea753251_3486074025400769579.jpg",
            From = new(2021, 11, 2, 18, 0, 0, UTC8),
            To = new(2021, 11, 23, 14, 59, 59, UTC8)
        },

        // 2.3 上半
        new("2.3","深秘之息", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "阿贝多" },
            UpPurpleList = new() { "班尼特", "诺艾尔", "罗莎莉亚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/11/22/75276539/0ab29581ea15452002abccf59c41359f_2943098344986593317.jpg",
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },
        new("2.3","浪涌之瞬", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "优菈" },
            UpPurpleList = new() { "班尼特", "诺艾尔", "罗莎莉亚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/11/22/75276539/561fd999c964dbe083792413d19cba9f_7019830319213578722.jpg",
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },
        new("2.3","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "松籁响起之时" },
            UpPurpleList = new() { "匣里龙吟", "暗巷的酒与诗", "祭礼大剑", "暗巷猎手", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/11/22/75276539/8fe1d0cc1cb799ea82525e6078661f5b_5040220209158931001.jpg",
            From = new(2021, 11, 24, 6, 0, 0, UTC8),
            To = new(2021, 12, 14, 17, 59, 59, UTC8)
        },

        // 2.3 下半
        new("2.3","鬼门斗宴", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "荒泷一斗" },
            UpPurpleList = new() { "五郎", "芭芭拉", "香菱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/10/75276539/b7b982612e9c8bc8fbf17179e5f495fe_4223117222364929849.jpg",
            From = new(2021, 12, 14, 18, 0, 0, UTC8),
            To = new(2022, 1, 4, 14, 59, 59, UTC8)
        },
        new("2.3","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "赤角石溃杵", "天空之翼" },
            UpPurpleList = new() { "暗巷闪光", "祭礼残章", "钟剑", "幽夜华尔兹", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/10/75276539/a361ec4869b35eb00f34a3c20c6ce251_7280437933234153888.jpg",
            From = new(2021, 12, 14, 18, 0, 0, UTC8),
            To = new(2022, 1, 4, 14, 59, 59, UTC8),
        },

        // 2.4 上半
        new("2.4","出尘入世", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "申鹤" },
            UpPurpleList = new() { "云堇", "凝光", "重云" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/30/75276539/537cb7fb02a8286f4806e4c399faff1a_2772270538090952068.jpg",
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },
        new("2.4","烟火之邀", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "魈" },
            UpPurpleList = new() { "云堇", "凝光", "重云" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/30/75276539/f66b02550d212cad60fcfc205195deed_7570096748237106680.jpg",
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },
        new("2.4","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "息灾", "和璞鸢" },
            UpPurpleList = new() { "笛剑", "流浪乐章", "西风大剑", "西风猎弓", "千岩长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/30/75276539/7ccbcd7ddd94be448e4565b6cc95dafd_6150433276674546820.jpg",
            From = new(2022, 1, 5, 6, 0, 0, UTC8),
            To = new(2022, 1, 25, 17, 59, 59, UTC8)
        },

        // 2.4 下半
        new("2.4","陵薮市朝", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "钟离" },
            UpPurpleList = new() { "行秋", "北斗", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/30/75276539/9344914c76e18d4db1a9257b8021ad1c_4463375112743299843.jpg",
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },
        new("2.4","浮生孰来", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "甘雨" },
            UpPurpleList = new() { "行秋", "北斗", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/31/75379477/c8f57ce1c7cf7d3e07e6be61fbf99b06_8543628235288722417.jpg",
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },
        new("2.4","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "阿莫斯之弓", "贯虹之槊" },
            UpPurpleList = new() { "西风剑", "西风秘典", "千岩古剑", "祭礼弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2021/12/30/75276539/e1e7107738f4eb99b818fa4bf8c183e4_1704339881159024745.jpg",
            From = new(2022, 1, 25, 18, 0, 0, UTC8),
            To = new(2022, 2, 15, 14, 59, 59, UTC8)
        },

        // 2.5 上半
        new("2.5","华紫樱绯", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "八重神子" },
            UpPurpleList = new() { "托马", "菲谢尔", "迪奥娜" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/02/11/75276557/2e423e722b2beb2ed1a450ab8f15d4f6_4101744926297735803.jpg",
            From = new(2022, 2, 16, 6, 0, 0, UTC8),
            To = new(2022, 3, 8, 17, 59, 59, UTC8)
        },
        new("2.5","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "磐岩结绿", "神乐之真意" },
            UpPurpleList = new() { "祭礼剑", "昭心", "雨裁", "绝弦", "断浪长鳍" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/02/11/75276539/1cf30722f4dfc98d5a94bf79bbde4ef2_3108987056799137870.jpg",
            From = new(2022, 2, 16, 6, 0, 0, UTC8),
            To = new(2022, 3, 8, 17, 59, 59, UTC8)
        },

        // 2.5 下半
        new("2.5","影寂天下人", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "雷电将军" },
            UpPurpleList = new() { "班尼特", "辛焱", "九条裟罗" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/03/75276539/51dfff9d8266e443269090b3ffdb7895_4731516586764145724.jpg",
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },
        new("2.5","浮岳虹珠", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpPurpleList = new() { "班尼特", "辛焱", "九条裟罗" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/03/75276539/605c355b9571d190a9f858ab78a11b8c_1303176581785630377.jpg",
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },
        new("2.5","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "不灭月华", "薙草之稻光" },
            UpPurpleList = new() { "匣里龙吟", "恶王丸", "祭礼残章", "曚云之月", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/03/75276539/62c52b0a1ee6b14fbff9b985e2fc954f_4298670707474265820.jpg",
            From = new(2022, 3, 8, 18, 0, 0, UTC8),
            To = new(2022, 3, 29, 14, 59, 59, UTC8)
        },

        // 2.6 上半
        new("2.6","苍流踏花", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫人" },
            UpPurpleList = new() { "砂糖", "香菱", "云堇" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/25/75276539/c9e1daedb9bcb7cb68bfb8271b943c2a_7566801419160244073.jpg",
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8)
        },
        new("2.6","杯装之诗", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "温迪" },
            UpPurpleList = new() { "砂糖", "香菱", "云堇" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/25/75276539/cc8fd153014a8ff4cdf9d786bd141b0f_4955843848549945274.jpg",
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8)
        },
        new("2.6","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "波乱月白经津", "终末嗟叹之诗" },
            UpPurpleList = new() { "笛剑", "流浪乐章", "祭礼大剑", "弓藏", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/03/25/75276539/395b16dea911a311b4b27479dc0ea61f_6597284420038101228.jpg",
            From = new(2022, 3, 30, 6, 0, 0, UTC8),
            To = new(2022, 4, 19, 17, 59, 59, UTC8) },

        // 2.6 下半
        new("2.6","白鹭之庭", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "神里绫华" },
            UpPurpleList = new() { "早柚", "雷泽", "罗莎莉亚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/04/12/75276539/a88e45a64e0ffdf76d5e8830c5c56431_9095398490365030813.jpg",
            From = new(2022, 4, 19, 18, 0, 0, UTC8),
            To = new(2022, 5, 31, 5, 59, 59, UTC8)
        },
        new("2.6","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "雾切之回光", "无工之剑" },
            UpPurpleList = new() { "西风剑", "西风秘典", "钟剑", "西风猎弓", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/04/12/75276539/5911c0886cc6ad0175995d04e8e7c4f9_6427271159272102902.jpg",
            From = new(2022, 4, 19, 18, 0, 0, UTC8),
            To = new(2022, 5, 31, 5, 59, 59, UTC8)
        },

        // 2.7 上半
        new("2.7","素霓伣天", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "夜兰" },
            UpPurpleList = new() { "诺艾尔", "芭芭拉", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/05/27/75276539/c3a9b5322fdba3ef42f6693bbdecb175_7462192138532328814.jpg",
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },
        new("2.7","烟火之邀", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "魈" },
            UpPurpleList = new() { "诺艾尔", "芭芭拉", "烟绯" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/05/27/75276539/aff63b8691f468988b8845eccf5769fa_6387962826256464447.jpg",
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },
        new("2.7","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "若水", "和璞鸢" },
            UpPurpleList = new() { "祭礼剑", "昭心", "西风大剑", "祭礼弓", "千岩长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/05/27/75276539/422c8780aa902d718bb2f87f2273f6fd_7429695283262439364.jpg",
            From = new(2022, 5, 31, 6, 0, 0, UTC8),
            To = new(2022, 6, 21, 17, 59, 59, UTC8)
        },

        // 2.7 下半
        new("2.7","鬼门斗宴", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "荒泷一斗" },
            UpPurpleList = new() { "五郎", "久岐忍", "重云" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/06/16/75276539/225a9d969a8cb4a80b18ce2d8ec8aa44_349540309482735122.jpg",
            From = new(2022, 6, 21, 18, 0, 0, UTC8),
            To = new(2022, 7, 12, 14, 59, 59, UTC8)
        },
        new("2.7","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "尘世之锁", "赤角石溃杵" },
            UpPurpleList = new() { "匣里龙吟", "祭礼残章", "千岩古剑", "绝弦", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/06/16/75276539/3aa1cc2021b077e9d06e1e3a216b2235_8199443572184454685.jpg",
            From = new(2022, 6, 21, 18, 0, 0, UTC8),
            To = new(2022, 7, 12, 14, 59, 59, UTC8)
        },

        // 2.8 上半
        new("2.8","叶落风随", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "枫原万叶" },
            UpPurpleList = new() { "鹿野院平藏", "托马", "凝光" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/07/08/75276539/4b7a3b766eeac1b8eeb209293594f835_6372322299772994841.jpg",
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },
        new("2.8","闪焰的驻足", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "可莉" },
            UpPurpleList = new() { "鹿野院平藏", "托马", "凝光" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/07/08/75276539/93df5c05d66cd35db4b0127367017514_8455083744581581916.jpg",
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },
        new("2.8","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "苍古自由之誓", "四风原典" },
            UpPurpleList = new() { "暗巷闪光", "流浪乐章", "雨裁", "幽夜华尔兹", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/07/08/75276539/e9d01c531bc1aab3af1c944cf90afd34_6065965793128437622.jpg",
            From = new(2022, 7, 13, 6, 0, 0, UTC8),
            To = new(2022, 8, 2, 17, 59, 59, UTC8)
        },

        // 2.8 下半
        new("2.8","焰色天河", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "宵宫" },
            UpPurpleList = new() { "云堇", "辛焱", "班尼特" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/07/26/75276539/2508d400ba2e8494867e05259d04b6cd_4432750527329040643.jpg",
            From = new(2022, 8, 2, 18, 0, 0, UTC8),
            To = new(2022, 8, 23, 14, 59, 59, UTC8)
        },
        new("2.8","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "斫峰之刃", "飞雷之弦振" },
            UpPurpleList = new() { "笛剑", "暗巷的酒与诗", "祭礼大剑", "暗巷猎手", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/07/26/75276539/9d395d16d047b4e98f1b020ae9bbc2f0_326236561515788014.jpg",
            From = new(2022, 8, 2, 18, 0, 0, UTC8),
            To = new(2022, 8, 23, 14, 59, 59, UTC8),
        },

        // 3.0 上半
        new("3.0","巡御蘙荟", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "提纳里" },
            UpPurpleList = new() { "柯莱", "迪奥娜", "菲谢尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/08/22/75276539/6492a98f486ae2d9f609cf6939bead1e_6307768016636993902.png",
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8)
        },
        new("3.0","陵薮市朝", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "钟离" },
            UpPurpleList = new() { "柯莱", "迪奥娜", "菲谢尔" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/08/19/75276539/fe9a2ed9d82c69b6f3c2db0cc7bbe4ef_2820143076681439127.png",
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8)
        },
        new("3.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "猎人之径", "贯虹之槊" },
            UpPurpleList = new() { "西风剑", "西风秘典", "钟剑", "绝弦", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/08/19/75276539/d2b4a357b0e15fcc115464b1627c88ae_694549458311939793.png",
            From = new(2022, 8, 24, 6, 0, 0, UTC8),
            To = new(2022, 9, 9, 17, 59, 59, UTC8),
        },

        // 3.0 下半
        new("3.0","浮生孰来", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "甘雨" },
            UpPurpleList = new() { "多莉", "砂糖", "行秋" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/08/75276539/bed2bd85d27ea92fd18072ef1ee8f0d2_2608294446368773787.jpg",
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8)
        },
        new("3.0","浮岳虹珠", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "珊瑚宫心海" },
            UpPurpleList = new() { "多莉", "砂糖", "行秋" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/08/75276539/7259ac8469cd11fbee77cd580b1a2a02_4662426434110958731.jpg",
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8),
        },
        new("3.0","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "不灭月华", "阿莫斯之弓" },
            UpPurpleList = new() { "祭礼剑", "昭心", "西风大剑", "弓藏", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/08/75276539/a6dcce9b0ac8ec5c82b3abecfb9d8315_1959915385520883844.jpg",
            From = new(2022, 9, 9, 18, 0, 0, UTC8),
            To = new(2022, 9, 27, 14, 59, 59, UTC8),
        },

         // 3.1 上半
        new("3.1","雳裁冥昭", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "赛诺" },
            UpPurpleList = new() { "坎蒂丝", "久岐忍", "早柚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/23/75276539/4e52a0f133b76534960baf4a58887e41_7357326130920782007.jpg",
            From = new(2022, 9, 28, 6, 0, 0, UTC8),
            To = new(2022, 10, 14, 17, 59, 59, UTC8)
        },
        new("3.1","杯装之诗", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "温迪" },
            UpPurpleList = new() { "坎蒂丝", "久岐忍", "早柚" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/23/75276539/60b01a15bb0b308905a06844947a61e0_2321666893357919476.jpg",
            From = new(2022, 9, 28, 6, 0, 0, UTC8),
            To = new(2022, 10, 14, 17, 59, 59, UTC8)
        },
        new("3.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "终末嗟叹之诗", "赤沙之杖" },
            UpPurpleList = new() { "匣里龙吟", "祭礼残章", "玛海菈的水色", "西风猎弓", "西风长枪" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/09/23/75276539/69cfcc5a98f063cdb102ce2c2189ee3b_1369481885815597001.jpg",
            From = new(2022, 9, 28, 6, 0, 0, UTC8),
            To = new(2022, 10, 14, 17, 59, 59, UTC8)
        },

        // 3.1 下半
        new("3.1","翩舞歈莲", GachaType.AvatarEventWish)
        {
            UpOrangeList = new() { "妮露" },
            UpPurpleList = new() { "北斗", "芭芭拉", "香菱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/10/10/75276539/c28413935dfed5cac374d92f4e7f1bf2_5567115929934800992.jpg",
            From = new(2022, 10, 14, 18, 0, 0, UTC8),
            To = new(2022, 11, 1, 14, 59, 59, UTC8)
        },
        new("3.1","深秘之息", GachaType.AvatarEventWish2)
        {
            UpOrangeList = new() { "阿贝多" },
            UpPurpleList = new() { "北斗", "芭芭拉", "香菱" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/10/10/75276539/ebefb1e1b2bcbc1759ffe76b64b284f8_7171947974583010403.jpg",
            From = new(2022, 10, 14, 18, 0, 0, UTC8),
            To = new(2022, 11, 1, 14, 59, 59, UTC8)
        },
        new("3.1","神铸赋形", GachaType.WeaponEventWish)
        {
            UpOrangeList = new() { "圣显之钥", "磐岩结绿" },
            UpPurpleList = new() { "西福斯的月光", "流浪的晚星", "雨裁", "祭礼弓", "匣里灭辰" },
            Banner = "https://upload-bbs.mihoyo.com/upload/2022/10/10/75276539/8dcb2cc5411fe3a4f7d917f0ab31cef9_8882775620455569461.jpg",
            From = new(2022, 10, 14, 18, 0, 0, UTC8),
            To = new(2022, 11, 1, 14, 59, 59, UTC8)
        },
    };

    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IPipeline.GenerateFile<GachaEvent>(gachaEvents, outputFolder, options);
    }
}