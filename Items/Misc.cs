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
using System.Collections.Generic;

namespace DecoTiles.Items
{
    public class UltimatePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Pickaxe");
            Tooltip.SetDefault("Mine to the darkest depths and the highest highs with this tool in your hands, the ultimate tool");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.pick = 20000000;
            item.rare = -12;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            Mod CalamityMod = ModLoader.GetMod("CalamityMod");
            if(CalamityMod != null)
            {
                recipe.AddIngredient(CalamityMod.ItemType("CrystylCrusher"));
            }
            recipe.AddRecipeGroup("DecoTiles:CelestialPicks");
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "PickPower")
                {
                    line2.text = ("??? pickaxe power");
                    line2.overrideColor = new Color(0, 203, 245, 62);
                }
            }
        }
        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            item.alpha = 62;
        }
    }
    public class UltimateHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Hamaxe");
            Tooltip.SetDefault("Trees and walls quiver in the presence of this tool, the ultimate tool");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.useTurn = true;
            item.axe = 20000000;
            item.hammer = 20000000;
            item.autoReuse = true;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = false;
            item.rare = -12;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "HammerPower")
                {
                    line2.text = ("??? hammer power");
                    line2.overrideColor = new Color(0, 203, 245, 62);
                }
                if (line2.mod == "Terraria" && line2.Name == "AxePower")
                {
                    line2.text = ("??? axe power");
                    line2.overrideColor = new Color(0, 203, 245, 62);
                }
            }
        }
        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            item.alpha = 62;
        }
    }
}