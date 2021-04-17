using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Bathtubs
{
    public class CardboardBathtubTile : QuickBath
    {
        public CardboardBathtubTile() : base("Cardboard Bathtub", 0, false, ItemType<CardboardBathtub>()) { }
    }
    public class CardboardBathtub : QuickTileItem
    {
        public CardboardBathtub() : base("Cardboard Bathtub", "Not the ideal bath", TileType<CardboardBathtubTile>(), 0) { }
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
