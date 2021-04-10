using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Items;
using DecoTiles.Tiles.Furn;

namespace DecoTiles.Tiles.Furn.Bookcases
{
    public class CardboardBookcaseTile : QuickBookcase
    {
        public CardboardBookcaseTile() : base("Cardboard Bookcase", 0, false, ItemType<CardboardBookcase>()) { }
    }
    public class CardboardBookcase : QuickTileItem
    {
        public CardboardBookcase() : base("Cardboard Bookcase", " ", TileType<CardboardBookcaseTile>(), 0) { }
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
    public class AlysianBookcaseTile : QuickBookcase
    {
        public AlysianBookcaseTile() : base("Alysian Bookcase", 0, false, ItemType<AlysianBookcase>()) { }
    }
    public class AlysianBookcase : QuickTileItem
    {
        public AlysianBookcase() : base("Alysian Bookcase", " ", TileType<AlysianBookcaseTile>(), 0) { }
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
