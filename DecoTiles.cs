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
using static DecoTiles.Tiles.Furn.FurnitureHelper;
using Terraria.Localization;
using Terraria.ID;

namespace DecoTiles
{
	public class DecoTiles : Mod
    {
        public static DecoTiles Instance { get; set; }
        public DecoTiles() { Instance = this; }
        public static void AutoloadFurniture()
        {
            if (Instance.Code != null)
            {
                foreach (Type type in Instance.Code.GetTypes().Where(t => t.IsSubclassOf(typeof(AutoFurniture))))
                {
                    (Activator.CreateInstance(type) as AutoFurniture).Load(Instance);
                }
            }
        }
        public override void Load()
        {
            AutoloadFurniture();
        }

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
    }
}