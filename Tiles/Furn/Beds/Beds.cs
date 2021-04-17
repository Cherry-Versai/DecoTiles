using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Beds
{
    public class CardboardBedTile : QuickBed
    {
        public CardboardBedTile() : base("Cardboard Bed", 0, false, ItemType<CardboardBed>()) { }
    }
    public class CardboardBed : QuickTileItem
    {
        public CardboardBed() : base("Cardboard Bed", " ", TileType<CardboardBedTile>(), 0) { }
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
