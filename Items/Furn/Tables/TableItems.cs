using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using System.Collections.Generic;

namespace DecoTiles.Items.Furn.Tables
{
   public class OfficeDesk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Office Desk");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 46;
            item.maxStack = 999;
            item.autoReuse = true;
            item.consumable = true;
            item.useTurn = true;
            item.useStyle = 1;
            item.useTime = 20;
            item.useAnimation = 5;
            item.rare = 0;
            item.createTile = mod.TileType("OfficeDeskTile");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(134, 182, 189);
                }
            }
        }
    }
    public class AlysianTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alysian Table");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 46;
            item.maxStack = 999;
            item.autoReuse = true;
            item.consumable = true;
            item.useTurn = true;
            item.useStyle = 1;
            item.useTime = 20;
            item.useAnimation = 5;
            item.rare = 0;
            item.createTile = mod.TileType("AlysianTableTile");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(134, 182, 189);
                }
            }
        }
    }
}
