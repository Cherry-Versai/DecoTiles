using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Chandeliers
{
    public class CardboardChandelierTile : QuickChandelier
    {
        public CardboardChandelierTile() : base("Cardboard Chandelier", 0, false, ItemType<CardboardChandelier>(), false) { }
    }
    public class CardboardChandelier : QuickTileItem
    {
        public CardboardChandelier() : base("Cardboard Chandelier", " ", TileType<CardboardChandelierTile>(), 0) { }
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
