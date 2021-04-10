using Terraria.DataStructures;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using DecoTiles.Items;


namespace DecoTiles.Tiles.Furn.Misc.Environment
{

    public class SandPillarLargeTile : QuickCustom
    {
        public SandPillarLargeTile() : base(" ", 0, false, ItemType<SandPillarLarge>(), 5, 6, new int[] { 16,16,16,16,16,18}, true, new Point16(0, 2)) { }
    }
    public class SandPillarLarge : QuickTileItem
    {
        public SandPillarLarge() : base("Large Sandstone Pillar", " ", TileType<SandPillarLargeTile>(), 0) { }
        public override void AddRecipes()
        {
            base.AddRecipes();
            {
                ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }
    public class SandPillarMediumTile : QuickCustom
    {
        public SandPillarMediumTile() : base(" ", 0, false, ItemType<SandPillarMedium>(), 4, 4, new int[] { 16, 16, 16, 18 }, true, new Point16(0, 2)) { }
    }
    public class SandPillarMedium : QuickTileItem
    {
        public SandPillarMedium() : base("Medium Sandstone Pillar", " ", TileType<SandPillarMediumTile>(), 0) { }
        public override void AddRecipes()
        {
            base.AddRecipes();
            {
                ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }
    public class SandPillarNormalTile : QuickCustom
    {
        public SandPillarNormalTile() : base(" ", 0, false, ItemType<SandPillarNormal>(), 4, 3, new int[] { 16, 16, 18 }, true, new Point16(0, 1)) { }
    }
    public class SandPillarNormal : QuickTileItem
    {
        public SandPillarNormal() : base( "Sandstone Pillar", " ", TileType<SandPillarNormalTile>(), 0) { }
        public override void AddRecipes()
        {
            base.AddRecipes();
            {
                ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }
    public class SandStoneCropTile : QuickCustom
    {
        public SandStoneCropTile() : base(" ", 0, false, ItemType<SandPillarNormal>(), 3, 2, new int[] { 16, 18 }, true, new Point16(0, 1)) { }
    }
    public class SandStoneCrop : QuickTileItem
    {
        public SandStoneCrop() : base("Medium Sandstone Pillar", " ", TileType<SandStoneCropTile>(), 0) { }
        public override void AddRecipes()
        {
            base.AddRecipes();
            {
                ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.Wood, 8);
                recipe.SetResult(this, 1);
                recipe.AddRecipe();
            }
        }
    }
}
