using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DecoTiles.Tiles.DecorBlock.Walls
{
	public class OfficeWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 191, SoundID.Dig, mod.ItemType("OfficeWall"), true, new Color(93, 96, 107)); } }
	public class AlysianPlatingWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 261, SoundID.Dig, mod.ItemType("AlysianPlatingWall"), true, new Color(153, 125, 118)); } }
	public class BlackBrickWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 191, SoundID.Dig, mod.ItemType("BlackBrickWall"), true, new Color(93, 96, 107)); } }
	public class BlackSlabWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 191, SoundID.Dig, mod.ItemType("BlackSlabWall"), true, new Color(93, 96, 107)); } }
	public class BlackTiledWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 191, SoundID.Dig, mod.ItemType("BlackTiledWall"), true, new Color(93, 96, 107)); } }
	public class HardSandstoneBrickWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 191, SoundID.Dig, mod.ItemType("HardSandstoneBrickWall"), true, new Color(93, 96, 107)); } }
	public class VoidCrystalBlueWallTile : ModWall
	{ public override void SetDefaults() { QuickBlock.QuickSetWall(this, 156, SoundID.Dig, mod.ItemType("VoidCrystalBlueWall"), true, new Color(255, 255, 255)); }
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.9f;
			g = 0.9f;
			b = 0.9f;
		}
	}
}