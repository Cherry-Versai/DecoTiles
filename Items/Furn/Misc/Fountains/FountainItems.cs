using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DecoTiles.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.GameContent.UI.States;
using IL.Terraria.IO;
using System.Collections.Generic;

namespace DecoTiles.Items.Furn.Misc.Fountains
{
    public class SpaceFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Space Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("SpaceFountainTile");
            item.rare = 1;
        }
    }
    public class HiveFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hive Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("HiveFountainTile");
            item.rare = 1;
        }
    }
    public class HellFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("HellFountainTile");
            item.rare = 1;
        }
    }
    public class TempleFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Temple Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("TempleFountainTile");
            item.rare = 1;
        }
    }
    public class MarbleFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marble Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("MarbleFountainTile");
            item.rare = 1;
        }
    }
    public class GraniteFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("GraniteFountainTile");
            item.rare = 1;
        }
    }
    public class UndIceFountainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Underground Ice Water Fountain");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = mod.TileType("UndIceFountainTile");
            item.rare = 1;
        }
    }
}