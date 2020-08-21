using Microsoft.Xna.Framework;
using static DecoTiles.Tiles.Furn.FurnitureHelper;
using static Terraria.ModLoader.ModContent;

namespace DecoTiles.Tiles.Furn.FurnitureSets
{
    class CardboardFurniture : AutoFurniture
    {
        public CardboardFurniture() : base("Cardboard", "DecoTiles/Tiles/Furn/FurnitureSets/Cardboard/", new Color(200, 150, 20), new Color(255, 220, 150), 0, ItemType<Items.DecorBlockItem.CardboardBox>()) { }
    }
}
