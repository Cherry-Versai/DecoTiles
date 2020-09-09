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
using DecoTiles.Items;
using Terraria.Graphics.Shaders;

namespace DecoTiles.Tiles.DecorBlock
{
	//Platform Tiles --------------------------------------------------------------------------------------
	internal class LabPlatformTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSetPlatform(this, 0, 191, SoundID.Dig, false, ItemType<Items.DecorBlockItem.LabPlatform>(), ""); } }
	internal class ThickWoodPlatformTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSetPlatform(this, 0, 7, SoundID.Dig, false, ItemType<Items.DecorBlockItem.ThickWoodPlatform>(), ""); } }
	internal class AlysianPlatingPlatformTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSetPlatform(this, 0, 261, SoundID.Tink, false, ItemType<Items.DecorBlockItem.AlysianPlatingPlatform>(), ""); } }
	internal class GrassPlatformTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSetPlatform(this, 0, 3, SoundID.Dig, false, ItemType<Items.DecorBlockItem.GrassPlatform>(), ""); } }
	internal class BlackBrickPlatformTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSetPlatform(this, 0, 191, SoundID.Tink, false, ItemType<Items.DecorBlockItem.BlackBrickPlatform>(), ""); } }
	//Platform Tiles --------------------------------------------------------------------------------------
	internal class WeatherBrickTile : ModTile
	{public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(40, 39, 47), ItemType<Items.DecorBlockItem.WeatherBrick>(), false, false, false, ""); }}
	internal class MoonplateTile : ModTile
	{public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(147, 145, 149), ItemType<Items.DecorBlockItem.Moonplate>(), false, false, false, ""); }}
	internal class AlysianPlatingTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 261, SoundID.Tink, new Color(199, 177, 152), ItemType<Items.DecorBlockItem.AlysianPlating>(), false, false, true, ""); }}
	internal class ChiselVoidCrystalBlockTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 156, SoundID.Tink, new Color(0, 203, 245), ItemType<Items.DecorBlockItem.ChiselVoidCrystalBlock>(), false, false, false, ""); }
		public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
		{ Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(0, 203, 245) * 0.0037f); }
	}
	internal class VoidCrystalBlockTile : ModTile
	{
		public override void SetDefaults()
		{
			QuickBlock.QuickSet(this, 0, 156, SoundID.Tink, new Color(0, 203, 245), ItemType<Items.DecorBlockItem.VoidCrystalBlock>(), false, false, false, "");
		}
		public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
		{
			Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(0, 203, 245) * 0.0037f);
		}
		public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
		{
			Tile tile = Main.tile[i, j];
			Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
			if (Main.drawToScreen)
			{
				zero = Vector2.Zero;
			}
			int height = tile.frameY == 36 ? 18 : 16;
			Main.spriteBatch.Draw(mod.GetTexture("Tiles/DecorBlock/VoidCrystalBlockTile_Glow"), new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY, 16, height), Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}
	}
	internal class BlackBrickTile : ModTile
	{public override void SetDefaults(){ QuickBlock.QuickSet(this, 65, 191, SoundID.Tink, new Color(40, 39, 47), ItemType<Items.DecorBlockItem.BlackBrick>(), true, false, false, ""); }}
	internal class OfficeFloorTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(40, 39, 47), ItemType<Items.DecorBlockItem.OfficeFloor>(), true, false, false, ""); } }
	internal class FieryBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(255, 84, 0), ItemType<Items.DecorBlockItem.FieryBrick>(), true, false, false, ""); } }
	internal class FertileDirtTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(90, 42, 42), ItemType<Items.DecorBlockItem.FertileDirt>(), true, false, false, ""); } }
	internal class PenumbraPlateTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(90, 42, 42), ItemType<Items.DecorBlockItem.PenumbraPlate>(), false, false, false, ""); }

	}
	internal class MagnetBlockTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 191, SoundID.Tink, new Color(255, 84, 0), ItemType<Items.DecorBlockItem.MagnetBlock>(), true, false, false, ""); } }
	internal class ChessboardBlockTile : ModTile
	{
		public override void SetDefaults()
		{
			QuickBlock.QuickSet(this, 0, 13, SoundID.Tink, new Color(255, 255, 255), ItemType<Items.DecorBlockItem.ChessboardBlock>(), true, false, false, "");
		}
	}
	internal class EldritchGrassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 261, SoundID.Dig, new Color(47, 40, 63), ItemType<Items.DecorBlockItem.EldritchGrass>(), false, false, true, ""); }
	}
	internal class PlasticGrassTile : ModTile
	{public override void SetDefaults() { QuickBlock.QuickSet(this, 0, 13, SoundID.Tink, new Color(141, 89, 39), ItemType<Items.DecorBlockItem.PlasticGrass>(), true, false, false, ""); } }
	internal class CoalstoneTile : ModTile
	{
		public override void SetDefaults()
		{
			QuickBlock.QuickSet(this, 0, 54, SoundID.Tink, new Color(37, 32, 41), ItemType<Items.DecorBlockItem.Coalstone>(), true, false, false, "");
		}
	}
	public class InfinityBlockTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlendAll[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileFrameImportant[Type] = false;
			drop = mod.ItemType("null");
			Main.tileSolidTop[Type] = false;
			Main.tileMerge[TileID.Dirt][TileID.Stone] = true;
			Main.tileNoAttach[Type] = false;
			Main.tileSolid[Type] = true;
			dustType = 76;
			soundType = SoundID.Tink;
			AddMapEntry(new Color(37, 32, 41));
		}
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
	internal class AuroraBrickTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 76, SoundID.Tink, new Color(109, 106, 165), ItemType<Items.DecorBlockItem.AuroraBrick>(), true, false, false, ""); }
	}
	internal class CrackedDirtTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 76, SoundID.Tink, new Color(153, 124, 95), ItemType<Items.DecorBlockItem.CrackedDirt>(), true, false, false, ""); }
	}
	internal class LivingBloodTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 72, SoundID.Drown, new Color(37, 32, 41), ItemType<Items.DecorBlockItem.LivingBlood>(), true, false, false, ""); animationFrameHeight = 88; }
		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			if (++frameCounter >= 4)
			{
				frameCounter = 0;
				if (++frame >= 4)
				{ frame = 0; }
			}
		}
	}
	internal class CryingObsidianTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 97, SoundID.Tink, new Color(37, 32, 41), ItemType<Items.DecorBlockItem.CryingObsidian>(), true, false, false, ""); }
	}
	internal class LavastoneTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 97, SoundID.Tink, new Color(37, 32, 41), ItemType<Items.DecorBlockItem.Lavastone>(), true, false, false, ""); }
	}

	internal class RedLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 117, SoundID.Tink, new Color(226, 64, 64), ItemType<Items.DecorBlockItem.RedLegoBrick>(), true, false, false, ""); } }
	internal class BlackLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 37, SoundID.Tink, new Color(53, 53, 53), ItemType<Items.DecorBlockItem.BlackLegoBrick>(), true, false, false, ""); } }
	internal class GreenLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 273, SoundID.Tink, new Color(26, 158, 62), ItemType<Items.DecorBlockItem.GreenLegoBrick>(), true, false, false, ""); } }
	internal class WhiteLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 76, SoundID.Tink, new Color(204, 204, 204), ItemType<Items.DecorBlockItem.WhiteLegoBrick>(), true, false, false, ""); } }
	internal class YellowLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 153, SoundID.Tink, new Color(232, 223, 67), ItemType<Items.DecorBlockItem.YellowLegoBrick>(), true, false, false, ""); } }
	internal class BlueLegoBrickTile : ModTile
	{ public override void SetDefaults() { QuickBlock.QuickSet(this, 65, 253, SoundID.Tink, new Color(72, 64, 221), ItemType<Items.DecorBlockItem.BlueLegoBrick>(), true, false, false, ""); } }
}
