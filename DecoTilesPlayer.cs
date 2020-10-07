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
using System.Collections.Specialized;
using System.Drawing;
using Color = Microsoft.Xna.Framework.Color;
using Terraria.Graphics.Shaders;

namespace DecoTiles
{
	public class DecoTilesPlayer : ModPlayer
	{
		public override void PostUpdateEquips()
		{
			if (Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 7)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile") ||
				(Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 6)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile") ||
				(Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 5)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile") ||
				(Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 4)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile") ||
				(Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 3)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile")
			|| (Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 2)].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile")))))))
			{
				player.gravity = 0.4f;
				player.AddBuff(BuffID.Gravitation, 20);
			}
			if (Main.tile[((int)(player.Center.X / 16) + 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile")
			|| Main.tile[((int)(player.Center.X / 16) - 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("GravitationPotionGlassTile"))
			{
				player.velocity = new Vector2(-1);

			}

			if (Main.tile[((int)(player.Center.X / 16) - 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile"))  //right
			{
				player.velocity = new Vector2(-1,0);
				player.gravity = 0;
			}
			else if (Main.tile[((int)(player.Center.X / 16) + 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile")) //left
			{
				player.velocity = new Vector2(1,0);
				player.gravity = 0;
			}
			else if (Main.tile[((int)(player.Center.X / 16)), ((int)(player.Center.Y / 16 + 1.5f))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile")) //top
			{
				player.velocity = new Vector2(0,1);
				player.gravity = 0;
			}
			else if (Main.tile[((int)(player.Center.X / 16)), ((int)(player.Center.Y / 16 - 1.5f))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile")) //bottom
			{
				player.velocity = new Vector2(0,-1);
				player.gravity = 0;
			}
		}
		public override void ModifyScreenPosition()
        {
			
        }

    }
}