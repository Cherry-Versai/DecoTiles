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
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
			recipe = new ModRecipe(mod);

            recipe.AddIngredient(mod, "ThickWoodPlatform", 1);
            recipe.SetResult(ItemID.Wood, 1);
            recipe.AddRecipe();
		}
	}

	public class AlysianPlatingPlatform : QuickTileItem
	{
		public AlysianPlatingPlatform() : base("Alysian Goddess Plating Platform", "", TileType<Tiles.DecorBlock.AlysianPlatingPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AlysianPlating", 1);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
			recipe = new ModRecipe(mod);

            recipe.AddIngredient(mod, "AlysianPlatingPlatform", 2);
            recipe.SetResult(mod, "AlysianPlating", 1);
            recipe.AddRecipe();
		}
	}

	public class LabPlatform : QuickTileItem
	{
		public LabPlatform() : base("Laboratory Platform", "", TileType<Tiles.DecorBlock.LabPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OfficeFloor", 1);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
			recipe = new ModRecipe(mod);

            recipe.AddIngredient(mod, "LabPlatform", 2);
            recipe.SetResult(mod, "OfficeFloor", 1);
            recipe.AddRecipe();
		}
	}

	public class GrassPlatform : QuickTileItem
	{
		public GrassPlatform() : base("Grass Platform", "", TileType<Tiles.DecorBlock.GrassPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.GrassSeeds, 1);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GrassPlatform", 2);
            recipe.SetResult(ItemID.DirtBlock, 1);
            recipe.AddRecipe();
		}
	}

	public class BlackBrickPlatform : QuickTileItem
	{
		public BlackBrickPlatform() : base("Black Dungeon Brick Platform", "", TileType<Tiles.DecorBlock.BlackBrickPlatformTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BlackBrick", 1);
            recipe.SetResult(this, 2); recipe.AddRecipe();
			recipe = new ModRecipe(mod);

            recipe.AddIngredient(mod, "BlackBrickPlatform", 2);
            recipe.SetResult(mod, "BlackBrick", 1); recipe.AddRecipe();
		}
	}
	//Platform Items ^




	//Lab Tiles v
	public class WeatherBrick : QuickTileItem
    {
        public WeatherBrick() : base("Weathered Bricks", "", TileType<Tiles.DecorBlock.WeatherBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

    public class ChiselVoidCrystalBlock : QuickTileItem
    {
        public ChiselVoidCrystalBlock() : base("Chiseled Void Crystal Block", "", TileType<Tiles.DecorBlock.ChiselVoidCrystalBlockTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "VoidCrystalBlock", 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

	public class VoidCrystalBlock : QuickTileItem
    {
        public VoidCrystalBlock() : base("Void Crystal Block", "'It hums faintly.'", TileType<Tiles.DecorBlock.VoidCrystalBlockTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 50);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class OfficeFloor : QuickTileItem
    {
        public OfficeFloor() : base("Office Floor", "", TileType<Tiles.DecorBlock.OfficeFloorTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
	//Lab Tiles ^

	//Plastic Tiles v
	public class PlasticGrass : QuickTileItem
    {
        public PlasticGrass() : base("Plastic Grass", "", TileType<Tiles.DecorBlock.PlasticGrassTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GreenLegoBrick", 25);
            recipe.AddIngredient(ItemID.DirtBlock, 25);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class RedLegoBrick : QuickTileItem
    {
        public RedLegoBrick() : base("Red Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.RedLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.RedDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class BlackLegoBrick : QuickTileItem
    {
        public BlackLegoBrick() : base("Black Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.BlackLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.BlackDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class YellowLegoBrick : QuickTileItem
    {
        public YellowLegoBrick() : base("Yellow Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.YellowLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.YellowDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
	public class GreenLegoBrick : QuickTileItem
    {
        public GreenLegoBrick() : base("Green Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.GreenLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.GreenDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class BlueLegoBrick : QuickTileItem
    {
        public BlueLegoBrick() : base("Blue Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.BlueLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.BlueDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class WhiteLegoBrick : QuickTileItem
    {
        public WhiteLegoBrick() : base("White Lego Brick", "'Try not to step on it!'", TileType<Tiles.DecorBlock.WhiteLegoBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.SilverDye, 1);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
	//Plastic Tiles ^	



	//Misc Tiles v
	public class Moonplate : QuickTileItem
	{
		public Moonplate() : base("Moonplate", "", TileType<Tiles.DecorBlock.MoonplateTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
		}
	}

	public class AlysianPlating : QuickTileItem
    {
        public AlysianPlating() : base("Alysian Goddess Plating", "", TileType<Tiles.DecorBlock.AlysianPlatingTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }

	public class FieryBrick : QuickTileItem
    {
        public FieryBrick() : base("Firey Bricks", "", TileType<Tiles.DecorBlock.FieryBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddIngredient(ItemID.Hellstone, 1);
            recipe.needLava = true;
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class CrackedDirt : QuickTileItem
    {
        public CrackedDirt() : base("Cracked Dirt", "Cannot spread or be planted with grass.", TileType<Tiles.DecorBlock.CrackedDirtTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SandBlock, 1);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }

	public class FertileDirt : QuickTileItem
    {
        public FertileDirt() : base("Fertile Dirt", "Wet.", TileType<Tiles.DecorBlock.FertileDirtTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 1);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.RottenChunk, 1);
            recipe.needWater = true;
            recipe.SetResult(this, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 1);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.Vertebrae, 1);
            recipe.needWater = true;
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }

	public class AuroraBrick : QuickTileItem
    {
        public AuroraBrick() : base("Aurora Brick", "", TileType<Tiles.DecorBlock.AuroraBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class CosmicCyst : QuickTileItem
    {
        public CosmicCyst() : base("Cosmic Cyst", "", TileType<Tiles.DecorBlock.CosmicCystTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 30);
            recipe.AddIngredient(ItemID.Meteorite, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class PenumbraPlate : QuickTileItem
    {
        public PenumbraPlate() : base("Penumbra Plating", "", TileType<Tiles.DecorBlock.PenumbraPlateTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Ashbrick", 50);
            recipe.AddIngredient(ItemID.Hellstone, 3);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

    public class HardSandstoneBrick : QuickTileItem
    {
        public HardSandstoneBrick() : base("Hardened Sandstone Brick", "", TileType<Tiles.DecorBlock.HardSandstoneBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HardenedSand, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

	public class LivingBlood : QuickTileItem
    {
        public LivingBlood() : base("Living Blood", "", TileType<Tiles.DecorBlock.LivingBloodTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 2);
            recipe.AddTile(TileID.FleshCloningVat);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 2);
            recipe.AddTile(TileID.FleshCloningVat); //What is the Corruption version of this???
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

    public class MagnetBlock : QuickTileItem
    {
        public MagnetBlock() : base("Magnet Block", "", TileType<Tiles.DecorBlock.MagnetBlockTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MartianConduitWall, 20);
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

	public class EldritchGrass : QuickTileItem
    {
        public EldritchGrass() : base("Eldritch Grass Block", "", TileType<Tiles.DecorBlock.EldritchGrassTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 50);
            recipe.AddIngredient(ItemID.CorruptSeeds, 1);
            recipe.AddTile(TileID.ImbuingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 50);
            recipe.AddIngredient(ItemID.CrimsonSeeds, 1);
            recipe.AddTile(TileID.ImbuingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class InfinityBlock : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Block");
			Tooltip.SetDefault("'It has no end.'");
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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddIngredient(ItemID.GoldBar, 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddIngredient(ItemID.PlatinumBar, 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class HardenedAsh : QuickTileItem
    {
        public HardenedAsh() : base("Hardened Ash", "", TileType<Tiles.DecorBlock.HardenedAshTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AshBlock, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }


    public class Ashbrick : QuickTileItem
    {
        public Ashbrick() : base("Ash Brick", "", TileType<Tiles.DecorBlock.AshbrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HardenedAsh", 2);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

	public class Basalt : QuickTileItem
    {
        public Basalt() : base("Basalt", "", TileType<Tiles.DecorBlock.BasaltTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.needLava = true;
            recipe.SetResult(this, 35);
            recipe.AddRecipe();
        }
    }

	public class TopazBrick : QuickTileItem
    {
        public TopazBrick() : base("Topaz Brick", "", TileType<Tiles.DecorBlock.TopazBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrayBrick, 50);
            recipe.AddIngredient(ItemID.Topaz, 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class CardboardBox : QuickTileItem
    {
        public CardboardBox() : base("Cardboard Box", "", TileType<Tiles.DecorBlock.LivingBloodTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }

	public class ChessboardBlock : QuickTileItem
	{
		public ChessboardBlock() : base("Chessboard Block", "", TileType<Tiles.DecorBlock.ChessboardBlockTile>(), 0) { }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MarbleBlock, 25);
            recipe.AddIngredient(ItemID.GraniteBlock, 25);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
	}
	//Misc Tiles ^



	//Dungeon Tiles v
	public class BlackBrick : QuickTileItem
    {
        public BlackBrick() : base("Black Dungeon Brick", "", TileType<Tiles.DecorBlock.BlackBrickTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Ashbrick", 50);
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddTile(TileID.BoneWelder);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Coalstone", 50);
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddTile(TileID.BoneWelder);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
	//Dungeon Tiles ^



	//Minecraft Tiles v
	public class Coalstone : QuickTileItem
    {
        public Coalstone() : base("Coalstone Block", "'Strangely familiar...'", TileType<Tiles.DecorBlock.CoalstoneTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AshBlock, 25);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.needLava = true;
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }

	public class CryingObsidian : QuickTileItem
	{
		public CryingObsidian() : base("Crying Obsidian", "'Strangely familiar...'", TileType<Tiles.DecorBlock.CryingObsidianTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Obsidian, 25);
            recipe.needWater = true;
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
		}
	}

	public class Lavastone : QuickTileItem
	{
		public Lavastone() : base("Lavastone", "'Strangely familiar...'", TileType<Tiles.DecorBlock.LavastoneTile>(), 0) { }
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AshBlock, 25);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.needLava = true;
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
	}
	//Minecraft Tiles ^
}
