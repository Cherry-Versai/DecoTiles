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

namespace DecoTiles.Tiles.Furn.Lanterns
{
	public class AlysianLanternTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile = new TileObjectData(TileObjectData.Style2xX);
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			Main.tileLighted[Type] = true;
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.Origin = new Point16(0, 0);
			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.Width = 2;
			TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
			AddMapEntry(new Color(191, 142, 111));
			dustType = 261;
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1.0f;
			g = 0.9f;
			b = 0.8f;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("AlysianLantern"));
		}
	}
}
