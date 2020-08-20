using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace DecoTiles.Items.Furn.Torches
{
    public class AlysianTorch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alysian Torch");
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
            item.createTile = mod.TileType("AlysianTorchTile");
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