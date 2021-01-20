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
using DecoTiles.UI;

namespace DecoTiles
{
	public class DecoTiles : Mod
    {
        internal BiomeMenuUI BiomeMenuUI;
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
        internal BiomeMenu BiomeMenu;
        private UserInterface _BiomeMenu;
        public override void Load()
        {
            AutoloadFurniture();
            BiomeMenuUI = new BiomeMenuUI();
            BiomeMenuUI.Activate();
            _BiomeMenu = new UserInterface();
            _BiomeMenu.SetState(BiomeMenu);
        }
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "DecoTiles: Biome Select Menu",
                    delegate
                    {
                        _BiomeMenu.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
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