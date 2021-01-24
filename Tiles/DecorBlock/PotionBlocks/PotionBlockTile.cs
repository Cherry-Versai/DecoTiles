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
using System;
using System.Security.Cryptography;

namespace DecoTiles.Tiles.DecorBlock.PotionBlocks
{
	internal class AmmoReservationPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.AmmoReservationPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.AmmoReservation, 2);  }
	}
	internal class ArcheryPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.ArcheryPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Archery, 2); player.magicDamage -= 0.2f; player.meleeDamage -= 0.2f; player.minionDamage -= 0.2f; }
	}
	internal class BattlePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.BattlePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Battle, 2);  }
	}
	internal class BuildersPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.BuildersPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Builder, 2); }
	}
	internal class CalmingPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.CalmingPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Calm, 2); }
	}
	internal class CratePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.CratePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Crate, 2); }
	}
	internal class DangersensePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.CratePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Dangersense, 2); }
	}
	internal class EndurancePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.EndurancePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Endurance, 2); player.statLifeMax2 -= 20; }
	}
	internal class FeatherFallPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.FeatherFallPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Featherfall, 2);}
	}
	internal class FishingPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.FishingPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Fishing, 2); }
	}
	internal class FlipperPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.FlipperPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Flipper, 2); }
	}
	internal class GenderChangePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{
			QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.GenderChangePotionGlass>(), true, false, false, "");
		}
		public override void FloorVisuals(Player player)
		{
			if (player.skinVariant == (PlayerVariantID.FemaleCoat))
			{ player.skinVariant = (PlayerVariantID.MaleCoat); }
			else if (player.skinVariant == PlayerVariantID.MaleCoat)
			{ player.skinVariant = (PlayerVariantID.FemaleCoat); }

			if (player.skinVariant == (PlayerVariantID.FemaleDress))
			{ player.skinVariant = (PlayerVariantID.MaleDress); }
			else if (player.skinVariant == PlayerVariantID.MaleDress)
			{ player.skinVariant = (PlayerVariantID.FemaleDress); }

			if (player.skinVariant == (PlayerVariantID.FemaleGangster))
			{ player.skinVariant = (PlayerVariantID.MaleGangster); }
			else if (player.skinVariant == PlayerVariantID.MaleGangster)
			{ player.skinVariant = (PlayerVariantID.FemaleGangster); }

			if (player.skinVariant == (PlayerVariantID.FemaleStarter))
			{ player.skinVariant = (PlayerVariantID.MaleStarter); }
			else if (player.skinVariant == PlayerVariantID.MaleStarter)
			{ player.skinVariant = (PlayerVariantID.FemaleStarter); }

			if (player.skinVariant == (PlayerVariantID.FemaleSticker))
			{ player.skinVariant = (PlayerVariantID.MaleSticker); }
			else if (player.skinVariant == PlayerVariantID.MaleSticker)
			{ player.skinVariant = (PlayerVariantID.FemaleSticker); }
		}
	}
	internal class GillsPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.GillsPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Gills, 2); }
	}
	internal class GravitationPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{
			QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.GravitationPotionGlass>(), true, false, false, "");
		}
		public override void FloorVisuals(Player player)
		{
			player.AddBuff(BuffID.Gravitation, 20);
		}
	}
	internal class HeartreachPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.HeartreachPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Heartreach, 2); }
	}
	internal class HunterPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.HunterPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Hunter, 2); }
	}
	internal class InfernoPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.InfernoPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Inferno, 2); }
	}
	internal class IronSkinPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.IronskinPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Ironskin, 2); player.moveSpeed -= 2; }
	}
	internal class InvisibilityPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.InvisibilityPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Invisibility, 2); }
	}
	internal class LifeforcePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.LifeforcePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Lifeforce, 2); }
	}
	internal class LovePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.LovePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Lovestruck, 2); }
	}
	internal class MagicPowerPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.MagicPowerPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.MagicPower, 2); }
	}
	internal class ManaRegenerationPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.ManaRegenerationPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.ManaRegeneration, 2); }
	}
	internal class MiningPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.MiningPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Mining, 2); }
	}
	internal class NightOwlPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.NightOwlPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.NightOwl, 2); }
	}
	internal class ObsidianSkinPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.ObsidianSkinPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.ObsidianSkin, 2); }
	}
	internal class RagePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.RagePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Rage, 2); }
	}
	internal class RecallPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.RecallPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{
			player.FindSpawn();
			if (player.SpawnX == -1 && player.SpawnY == -1)
			{ player.Teleport(new Vector2(Main.spawnTileX, Main.spawnTileY - 2) * 16); }
			else
			{ player.Teleport(new Vector2(player.SpawnX, player.SpawnY - 2) * 16); }
			
		}
	}
	internal class RegenerationPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.RegenerationPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Regeneration, 2); }
	}
	internal class ShinePotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.ShinePotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Shine, 2); }
	}
	internal class SonarPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.SonarPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Sonar, 2); }
	}
	internal class SpelunkerPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.SpelunkerPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Spelunker, 2); }
	}
	internal class StinkPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.StinkPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Stinky, 2); }
	}
	internal class SummonerPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.SummoningPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Summoning, 2); }
	}
	internal class SwiftnessPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.SwiftnessPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Swiftness, 2); }
	}
	internal class ThornsPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.ThornsPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Thorns, 2); }
	}
	internal class TitanPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.TitanPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Titan, 2); }
	}
	internal class WarmthPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.WarmthPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Warmth, 2); }
	}
	internal class WaterWalkingPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.WaterWalkingPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.WaterWalking, 2); }
	}
	internal class WrathPotionGlassTile : ModTile
	{
		public override void SetDefaults()
		{ QuickBlock.QuickSet(this, 0, 13, SoundID.Shatter, new Color(200, 246, 254), ItemType<Items.DecorBlockItem.PotionBlockItems.WrathPotionGlass>(), true, false, false, ""); }
		public override void FloorVisuals(Player player)
		{ player.AddBuff(BuffID.Wrath, 2); }
	}
	//Potion Tank Blocks -------------------------------------------------------
}
