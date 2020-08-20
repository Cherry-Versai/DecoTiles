using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static DecoTiles.Tiles.Furn.FurnitureHelper;
using static Terraria.ModLoader.ModContent;

namespace DecoTiles.Tiles.Furn
{
    class CardboardFurniture : AutoFurniture
    {
        public CardboardFurniture() : base("Cardboard", "DecoTiles/Tiles/Furn/FurnitureSets/Cardboard", new Color(200, 150, 20), new Color(255, 220, 150), 0, ItemType<Items.DecorBlockItem.CardboardBox>()) { }
    }
}
