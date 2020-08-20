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
	public class DecoTilesPlayer : ModPlayer
	{
		public override void PostUpdateEquips()
        {
			if (Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 2)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile"))
            {
				player.AddBuff(BuffID.Gravitation, 20);
			}

		}

	}
}