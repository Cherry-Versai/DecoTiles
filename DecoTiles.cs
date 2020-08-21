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
    }
}