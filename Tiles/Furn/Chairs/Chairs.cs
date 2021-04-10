using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Chairs
{
    public class CardboardChairTile : QuickChair
    {
        public CardboardChairTile() : base("Cardboard Chair", 0, false, ItemType<CardboardChair>()) { }
    }
    public class CardboardChair : QuickTileItem
    {
        public CardboardChair() : base("Cardboard Chair", "", TileType<CardboardChairTile>(), 0) { }
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
    public class AlysianChairTile : QuickChair
    {
        public AlysianChairTile() : base("Alysian Chair", 0, false, ItemType<AlysianChair>()) { }
    }
    public class AlysianChair : QuickTileItem
    {
        public AlysianChair() : base("Alysian Chair", "", TileType<AlysianChairTile>(), 0) { }
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
