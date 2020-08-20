using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace DecoTiles.Items.Furn.Chests
{
    public class LabChest : QuickTileItem
    {
        public LabChest() : base("Laboratory Chest", "", TileType<Tiles.Furn.Chests.LabChestTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "OfficeFloor", 1); recipe.AddIngredient(ItemID.IronBar, 2); recipe.SetResult(this, 2); recipe.AddRecipe();
        }
    }
    public class AlysianChest : QuickTileItem
    {
        public AlysianChest() : base("Alysia Chest", "", TileType<Tiles.Furn.Chests.LabChestTile>(), 0) { }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(mod, "OfficeFloor", 1); recipe.AddIngredient(ItemID.IronBar, 2); recipe.SetResult(this, 2); recipe.AddRecipe();
        }
    }
}