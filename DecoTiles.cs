using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DecoTiles.Tiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.Graphics.Effects;
using static Terraria.ModLoader.ModContent;
using DecoTiles.Tiles.Furn;
using Terraria.Localization;
using Terraria.ID;

namespace DecoTiles
{
	public class DecoTiles : Mod
    {
        public bool SpirtMod = false;


        public static DecoTiles Instance { get; set; }
        public DecoTiles() { Instance = this; }

        public override void AddRecipeGroups()
        {           
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Celestial Pickaxe", new int[]
            {
                ItemID.VortexPickaxe,
                ItemID.NebulaPickaxe,
                ItemID.StardustPickaxe,
                ItemID.SolarFlarePickaxe

            }); ; ; ;
            RecipeGroup.RegisterGroup("DecoTiles:CelestialPicks", group);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Spike);
            recipe.AddRecipe();
        }
        public override void Unload()
        {
        }
        public override void Load()
        {
        }

    }
}