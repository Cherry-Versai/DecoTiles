using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Candelabras
{
    public class CardboardCandelabraTile : QuickCandelabra
    {
        public CardboardCandelabraTile() : base("Cardboard Candelabra", 0, false, ItemType<CardboardCandelabra>(), false) { }
    }
    public class CardboardCandelabra : QuickTileItem
    {
        public CardboardCandelabra() : base("Cardboard Candelabra", " ", TileType<CardboardCandelabraTile>(), 0) { }
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
