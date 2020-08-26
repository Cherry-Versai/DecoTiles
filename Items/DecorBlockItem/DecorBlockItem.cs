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

namespace DecoTiles.Items.DecorBlockItem
{
	//Platform Items v
	public class ThickWoodPlatform : QuickTileItem
	{
		public ThickWoodPlatform() : base("Thick Wooden Platform", "", TileType<Tiles.DecorBlock.ThickWoodPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 1); recipe.AddTile(TileID.HeavyWorkBench); recipe.SetResult(this, 1); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "ThickWoodPlatform", 2); recipe.SetResult(ItemID.Wood, 1); recipe.AddRecipe();
		}
	}
	public class AlysianPlatingPlatform : QuickTileItem
	{
		public AlysianPlatingPlatform() : base("Alysian Goddess Plating Platform", "", TileType<Tiles.DecorBlock.AlysianPlatingPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "AlysianPlating", 1); recipe.SetResult(this, 2); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "AlysianPlatingPlatform", 2); recipe.SetResult(mod, "AlysianPlating", 1); recipe.AddRecipe();
		}
	}
	public class LabPlatform : QuickTileItem
	{
		public LabPlatform() : base("Laboratory Platform", "", TileType<Tiles.DecorBlock.LabPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "OfficeFloor", 1); recipe.SetResult(this, 2); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "LabPlatform", 2); recipe.SetResult(mod, "OfficeFloor", 1); recipe.AddRecipe();
		}
	}
	public class GrassPlatform : QuickTileItem
	{
		public GrassPlatform() : base("Grass Platform", "", TileType<Tiles.DecorBlock.GrassPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.DirtBlock, 1); recipe.AddIngredient(ItemID.GrassSeeds, 1); recipe.SetResult(this, 2); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "GrassPlatform", 2); recipe.SetResult(ItemID.DirtBlock, 1); recipe.AddRecipe();
		}
	}
	public class BlackBrickPlatform : QuickTileItem
	{
		public BlackBrickPlatform() : base("Black Dungeon Brick Platform", "", TileType<Tiles.DecorBlock.BlackBrickPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrick", 1); recipe.SetResult(this, 2); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrickPlatform", 2); recipe.SetResult(mod, "BlackBrick", 1); recipe.AddRecipe();
		}
	}
	//Platform Items ^




	//Lab Tiles v
	public class WeatherBrick : QuickTileItem { public WeatherBrick() : base("Weathered Bricks", "", TileType<Tiles.DecorBlock.WeatherBrickTile>(), 0) { } }
	public class ChiselVoidCrystalBlock : QuickTileItem { public ChiselVoidCrystalBlock() : base("Chiseled Void Crystal Block", "", TileType<Tiles.DecorBlock.ChiselVoidCrystalBlockTile>(), 0) { } }
	public class VoidCrystalBlock : QuickTileItem { public VoidCrystalBlock() : base("Void Crystal Block", "", TileType<Tiles.DecorBlock.VoidCrystalBlockTile>(), 0) { } }
	public class OfficeFloor : QuickTileItem { public OfficeFloor() : base("Void Crystal Block", "", TileType<Tiles.DecorBlock.OfficeFloorTile>(), 0) { } }
	//Lab Tiles ^

	//Plastic Tiles v
	public class PlasticGrass : QuickTileItem { public PlasticGrass() : base("Plastic Grass", "", TileType<Tiles.DecorBlock.PlasticGrassTile>(), 0) { } }
	public class RedLegoBrick : QuickTileItem { public RedLegoBrick() : base("Red Lego Brick", "", TileType<Tiles.DecorBlock.RedLegoBrickTile>(), 0) { } }
	public class BlackLegoBrick : QuickTileItem { public BlackLegoBrick() : base("Black Lego Brick", "", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { } }
	public class YellowLegoBrick : QuickTileItem { public YellowLegoBrick() : base("Yellow Lego Brick", "", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { } }
	public class GreenLegoBrick : QuickTileItem { public GreenLegoBrick() : base("Green Lego Brick", "", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { } }
	public class BlueLegoBrick : QuickTileItem { public BlueLegoBrick() : base("Blue Lego Brick", "", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { } }
	public class WhiteLegoBrick : QuickTileItem { public WhiteLegoBrick() : base("White Lego Brick", "", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { } }
	//Plastic Tiles ^	



	//Misc Tiles v
	public class Moonplate : QuickTileItem
	{
		public Moonplate() : base("Moonplate", "", TileType<Tiles.DecorBlock.MoonplateTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrick", 1); recipe.SetResult(this, 2); recipe.AddRecipe();
		}
	}
	public class AlysianPlating : QuickTileItem { public AlysianPlating() : base("Alysian Goddess Plating", "", TileType<Tiles.DecorBlock.AlysianPlatingTile>(), 0) { } }
	public class FieryBrick : QuickTileItem { public FieryBrick() : base("Firey Bricks", "", TileType<Tiles.DecorBlock.FieryBrickTile>(), 0) { } }
	public class CrackedDirt : QuickTileItem { public CrackedDirt() : base("Cracked Dirt", "Grass can't grow on it", TileType<Tiles.DecorBlock.CrackedDirtTile>(), 0) {  } public override void AddRecipes() { ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.SandBlock, 1); recipe.AddIngredient(ItemID.DirtBlock, 1); recipe.SetResult(this, 2); recipe.AddRecipe(); } }
	public class AuroraBrick : QuickTileItem { public AuroraBrick() : base("Aurora Brick", "", TileType<Tiles.DecorBlock.AuroraBrickTile>(), 0) { } }
	public class LivingBlood : QuickTileItem { public LivingBlood() : base("Living Blood", "", TileType<Tiles.DecorBlock.LivingBloodTile>(), 0) { } }
	public class MagnetBlock : QuickTileItem { public MagnetBlock() : base("Magnet Block", "", TileType<Tiles.DecorBlock.MagnetBlockTile>(), 0) { } }
	public class InfinityBlock : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Block");
			Tooltip.SetDefault("It has no end");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 10;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = false;
			item.createTile = TileType<Tiles.DecorBlock.InfinityBlockTile>();
			item.rare = 0;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			foreach (TooltipLine line2 in tooltips)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color(134, 182, 189);
				}
			}
		}
	}
	public class CardboardBox : QuickTileItem { public CardboardBox() : base("Cardboard Box", "", TileType<Tiles.DecorBlock.LivingBloodTile>(), 0) { } }
	public class ChessboardBlock : QuickTileItem
	{
		public ChessboardBlock() : base("Chessboard Block", "", TileType<Tiles.DecorBlock.ChessboardBlockTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.MarbleBlock, 25); recipe.AddIngredient(ItemID.GraniteBlock, 25); recipe.AddTile(TileID.HeavyWorkBench); recipe.SetResult(this, 50); recipe.AddRecipe(); }
	}
	//Misc Tiles ^



	//Dungeon Tiles v
	public class BlackBrick : QuickTileItem { public BlackBrick() : base("Black Dungeon Brick", "", TileType<Tiles.DecorBlock.BlackBrickTile>(), 0) { } }
	//Dungeon Tiles ^



	//Minecraft Tiles v
	public class Coalstone : QuickTileItem { public Coalstone() : base("Coalstone Block", "Strangely familiar...", TileType<Tiles.DecorBlock.CoalstoneTile>(), 0) { } }
	public class CryingObsidian : QuickTileItem
	{
		public CryingObsidian() : base("Crying Obsidian", "", TileType<Tiles.DecorBlock.CryingObsidianTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.needWater = true; recipe.AddIngredient(ItemID.Obsidian, 25); recipe.SetResult(this, 25); recipe.AddRecipe();
		}
	}
	public class Lavastone : QuickTileItem
	{
		public Lavastone() : base("Lavastone", "", TileType<Tiles.DecorBlock.LavastoneTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.needLava = true; recipe.AddIngredient(ItemID.StoneBlock, 25); recipe.SetResult(this, 50); recipe.AddRecipe();
		}
	}
	//Minecraft Tiles ^
}
