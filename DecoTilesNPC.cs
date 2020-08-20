using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DecoTiles.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.GameContent.UI.States;
using IL.Terraria.IO;
using DecoTiles.Items.DecorBlockItem;
using DecoTiles.Items.DecorBlockItem.Walls;

namespace DecoTiles
{
	public class DecoTilesNPC : GlobalNPC
	{
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Clothier)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("BlackBrick"));
                shop.item[nextSlot].value = 0;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("BlackBrickWall"));
                shop.item[nextSlot].value = 0;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("BlackTiledWall"));
                shop.item[nextSlot].value = 0;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("BlackSlabWall"));
                shop.item[nextSlot].value = 0;
                nextSlot++;
            }
        }
    }
}