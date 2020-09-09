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
			if (Main.tile[(int)(player.Center.X / 16 + 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("niceblocks").TileType("ElectricFenceTile") //This line detects when the player is in the tile directly right of the tile specified in "TIleName"
			|| (Main.tile[(int)(player.Center.X / 16 - 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("niceblocks").TileType("ElectricFenceTile") //directly left of the tile
			|| (Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) + 2)].type == ModLoader.GetMod("niceblocks").TileType("ElectricFenceTile") //on top
			|| (Main.tile[(int)(player.Center.X / 16), ((int)(player.Center.Y / 16) - 2)].type == ModLoader.GetMod("niceblocks").TileType("ElectricFenceTile"))))) //on the bottom of the tile
		    {
				player.Hurt(PlayerDeathReason.ByCustomReason(player.name + "custom death message here"), 25, 0); //the death message should be self explainitory. The numbers are defining the damage and the direction(dunno what this means exactly, haven't tried it), so in this example it does 25 base damage and doesn't move the player.
				player.StickyMovement();
			}
		}
		public override void ModifyScreenPosition()
        {
			
        }

    }
}/*
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

			if (Main.tile[((int)(player.Center.X / 16) + 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile"))
            {
				player.velocity = new Vector2(-10, player.velocity.Y);
			}
			else if (Main.tile[((int)(player.Center.X / 16) - 1), ((int)(player.Center.Y / 16))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile"))
			{
				player.velocity = new Vector2(10, player.velocity.Y);
			}
			else if (Main.tile[((int)(player.Center.X / 16)), ((int)(player.Center.Y / 16 + 2))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile"))
			{
				player.velocity = new Vector2(10, player.velocity.Y);
			}
			else if (Main.tile[((int)(player.Center.X / 16)), ((int)(player.Center.Y / 16 + 2))].type == ModLoader.GetMod("DecoTiles").TileType("MagnetBlockTile"))
			{
				player.velocity = new Vector2(10, player.velocity.Y);
			}

*/