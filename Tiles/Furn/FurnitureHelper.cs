using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using System;
using Terraria.Localization;

namespace DecoTiles.Tiles.Furniture
{
    internal static class FurnitureHelper
    {

        public static void QuickSetFurniture(this ModTile tile, int width, int height, int dustType, int soundType, bool tallBottom, bool solidTop = false, bool solid = false, string mapName = "")
        {
            Main.tileLavaDeath[tile.Type] = false;
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileSolidTop[tile.Type] = solidTop;
            Main.tileSolid[tile.Type] = solid;

            TileObjectData.newTile.Width = width;
            TileObjectData.newTile.Height = height;
            TileObjectData.newTile.CoordinateHeights = new int[height];

            for (int k = 0; k < height; k++)
            {
                TileObjectData.newTile.CoordinateHeights[k] = 16;
            }

            if (tallBottom) TileObjectData.newTile.CoordinateHeights[height - 1] = 18;
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.Origin = new Point16(0, 0);

            TileObjectData.addTile(tile.Type);

            ModTranslation name = tile.CreateMapEntryName();
            name.SetDefault(mapName);
            tile.AddMapEntry(new Color(191, 133, 93), name);
            tile.dustType = dustType;
            tile.soundType = soundType;
            tile.disableSmartCursor = true;
        }

        public static void QuickTorchTile(this ModTile tile, bool waterDeath, int torchDrop, int r, int b, int g, float lightIntense)
        {
            Main.tileLighted[tile.Type] = true;
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileNoAttach[tile.Type] = true;
            Main.tileNoFail[tile.Type] = true;
            Main.tileWaterDeath[tile.Type] = waterDeath;
            TileObjectData.newTile.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorAlternateTiles = new[] { 124 };
            TileObjectData.addAlternate(1);
            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree | AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorAlternateTiles = new[] { 124 };
            TileObjectData.addAlternate(2);
            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.AnchorWall = true;
            TileObjectData.addAlternate(0);
            TileObjectData.addTile(tile.Type);
            tile.AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
            tile.AddMapEntry(new Color(191, 142, 111));
            tile.disableSmartCursor = true;
            tile.adjTiles = new int[] { TileID.Torches };
            tile.torch = true;
            tile.drop = torchDrop;
        }

        public static void QuickChestTile(this ModTile tile, int drop, string chest = "", string chestName = "")
        {
            Main.tileSpelunker[tile.Type] = true;
            Main.tileContainer[tile.Type] = true;
            Main.tileShine2[tile.Type] = true;
            Main.tileShine[tile.Type] = 1200;
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileNoAttach[tile.Type] = true;
            Main.tileValue[tile.Type] = 500;
            TileID.Sets.HasOutlines[tile.Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
            TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
            TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(tile.Type);
            ModTranslation name = tile.CreateMapEntryName();
            name.SetDefault(chestName);
            tile.AddMapEntry(new Color(233, 207, 94), name);
            tile.disableSmartCursor = true;
            tile.adjTiles = new int[] { TileID.Containers };
            tile.chest = chest;
            tile.chestDrop = drop;
        }
        public static void QuickWorkbenchTile(this ModTile tile, int drop, int dustType, bool lavaDeath)
        {
            Main.tileSolidTop[tile.Type] = true;
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileNoAttach[tile.Type] = true;
            Main.tileTable[tile.Type] = true;
            Main.tileLavaDeath[tile.Type] = lavaDeath;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(tile.Type);
            tile.AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            tile.AddMapEntry(new Color(200, 200, 200));
            tile.dustType = dustType;
            tile.disableSmartCursor = true;
            tile.adjTiles = new int[] { TileID.WorkBenches };
            tile.drop = drop;
        }
        public static void QuickTableTile(this ModTile tile, int drop, int dustType, bool lavaDeath)
        {
            Main.tileSolidTop[tile.Type] = true;
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileNoAttach[tile.Type] = true;
            Main.tileTable[tile.Type] = true;
            Main.tileLavaDeath[tile.Type] = lavaDeath;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(tile.Type);
            tile.AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            tile.AddMapEntry(new Color(200, 200, 200));
            tile.dustType = dustType;
            tile.disableSmartCursor = true;
            tile.adjTiles = new int[] { TileID.Tables };
            tile.drop = drop;
        }
        public static void QuickClockTile(this ModTile tile, int dustType)
        {
            Main.tileFrameImportant[tile.Type] = true;
            Main.tileNoAttach[tile.Type] = true;
            Main.tileLavaDeath[tile.Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16, 16 };
            TileObjectData.addTile(tile.Type);
            ModTranslation name = tile.CreateMapEntryName();
            tile.AddMapEntry(new Color(200, 200, 200), name);
            tile.dustType = dustType;
            tile.adjTiles = new int[] { TileID.GrandfatherClocks };
        }
        public static bool Time(int x, int y)
        {
            string text = "AM";
            double time = Main.time;
            if (!Main.dayTime)
            { time += 54000.0; }
            time = time / 86400.0 * 24.0;
            time = time - 7.5 - 12.0;
            if (time < 0.0)
            { time += 24.0; }
            if (time >= 12.0)
            { text = "PM"; }
            int intTime = (int)time;
            double deltaTime = time - intTime;
            deltaTime = (int)(deltaTime * 60.0);
            string text2 = string.Concat(deltaTime);
            if (deltaTime < 10.0)
            { text2 = "0" + text2; }
            if (intTime > 12)
            { intTime -= 12; }
            if (intTime == 0)
            { intTime = 12; }
            var newText = string.Concat("Time: ", intTime, ":", text2, " ", text);
            Main.NewText(newText, 255, 240, 20);
            return true;
        }
    }
}