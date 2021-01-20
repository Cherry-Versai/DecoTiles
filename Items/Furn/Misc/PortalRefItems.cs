using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace DecoTiles.Items.Furn.Misc
{
    public class PortalCube1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Companion Cube");
            Tooltip.SetDefault("...");
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
            item.rare = 1;
            item.createTile = mod.TileType("PortalCube1Tile");
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