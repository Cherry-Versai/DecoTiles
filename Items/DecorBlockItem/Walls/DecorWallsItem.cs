using Microsoft.Xna.Framework;
using DecoTiles.Tiles.DecorBlock.Walls;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace DecoTiles.Items.DecorBlockItem.Walls
{
	public class OfficeWall : QuickWallItem 
	{
		public OfficeWall() : base("Office Wall", "", WallType<OfficeWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "OfficeFloor", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "OfficeWall", 4); recipe.SetResult(mod, "OfficeFloor", 1); recipe.AddRecipe();
		}
	}
	public class BlackBrickWall : QuickWallItem
	{
		public BlackBrickWall() : base("Black Dungeon Brick Wall", "", WallType<BlackBrickWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrick", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrickWall", 4); recipe.SetResult(mod, "BlackBrick", 1); recipe.AddRecipe();
		}
	}
	public class BlackTiledWall : QuickWallItem
	{
		public BlackTiledWall() : base("Black Tiled Dungeon Brick Wall", "", WallType<BlackTiledWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrick", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackTiledWall", 4); recipe.SetResult(mod, "BlackBrick", 1); recipe.AddRecipe();
		}
	}
	public class BlackSlabWall : QuickWallItem
	{
		public BlackSlabWall() : base("Black Slab Dungeon Brick Wall", "", WallType<BlackTiledWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackBrick", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "BlackSlabWall", 4); recipe.SetResult(mod, "BlackBrick", 1); recipe.AddRecipe();
		}
	}
	public class AlysianPlatingWall : QuickWallItem
	{
		public AlysianPlatingWall() : base("Alysian Goddess Plating Wall", "", WallType<BlackTiledWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "AlysianPlating", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "AlysianPlatingWall", 4); recipe.SetResult(mod, "AlysianPlating", 1); recipe.AddRecipe();
		}
	}
	public class VoidCrystalBlueWall : QuickWallItem
	{
		public VoidCrystalBlueWall() : base("Blue Void Crystal Wall", "", WallType<BlackTiledWallTile>()) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "VoidCrystalBlock", 1); recipe.AddTile(TileID.WorkBenches); recipe.SetResult(this, 4); recipe.AddRecipe();
			recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "VoidCrystalBlueWall", 4); recipe.SetResult(mod, "VoidCrystalBlock", 1); recipe.AddRecipe();
		}
	}
}


