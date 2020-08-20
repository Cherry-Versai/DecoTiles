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
using System.Collections.Generic;

namespace DecoTiles.Items.DecorBlockItem.PotionBlockItems
{
	public class AmmoReservationPotionGlass : QuickTileItem
	{
		public AmmoReservationPotionGlass() : base("Ammo Reservation Potion Block", "20% chance to not consume ammo when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.AmmoReservationPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.AmmoReservationPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class ArcheryPotionGlass : QuickTileItem
	{
		public ArcheryPotionGlass() : base("Archery Potion Block", "20% increased arrow speed and damage when stood on.\nReduces melee, magic, and summon damage when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.ArcheryPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.ArcheryPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class BattlePotionGlass : QuickTileItem
	{
		public BattlePotionGlass() : base("Battle Potion Block", "Increases enemy spawn rate when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.BattlePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.BattlePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class BuildersPotionGlass : QuickTileItem
	{
		public BuildersPotionGlass() : base("Builders Potion Block", "Increases placement speed and range when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.BuildersPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.BuilderPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class CalmingPotionGlass : QuickTileItem
	{
		public CalmingPotionGlass() : base("Calming Potion Block", "Decreases enemy spawn rate when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.CalmingPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.CalmingPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class CratePotionGlass : QuickTileItem
	{
		public CratePotionGlass() : base("Crate Potion Block", "Increases chance to get a crate when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.CratePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.CratePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class DangersensePotionGlass : QuickTileItem
	{
		public DangersensePotionGlass() : base("Dangersense Potion Block", "Allows you to see nearby danger sources when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.DangersensePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.TrapsightPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class EndurancePotionGlass : QuickTileItem
	{
		public EndurancePotionGlass() : base("Endurance Potion Block", "Reduces damage taken by 10% when stood on\nReduces max life by 20 when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.EndurancePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.EndurancePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class FeatherFallPotionGlass : QuickTileItem
	{
		public FeatherFallPotionGlass() : base("Feather Falling Potion Block", "Slows falling speed when stood on.\nDoesn't make a whole lot of sense, nor is it useful but decoration maybe?", TileType<Tiles.DecorBlock.PotionBlocks.FeatherFallPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.FeatherfallPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class FishingPotionGlass : QuickTileItem
	{
		public FishingPotionGlass() : base("Fishing Potion Block", "Increases fishing power when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.FishingPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.FishingPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class FlipperPotionGlass : QuickTileItem
	{
		public FlipperPotionGlass() : base("Flipper Potion Block", "Lets you move swiftly in liquids when stood on.\nUseless function but that's not the point.", TileType<Tiles.DecorBlock.PotionBlocks.FlipperPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.FlipperPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class GillsPotionGlass : QuickTileItem
	{
		public GillsPotionGlass() : base("Gills Potion Block", "Breathe water instead of air when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.GillsPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.GillsPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class GenderChangePotionGlass : QuickTileItem
	{
		public GenderChangePotionGlass() : base("Gender Change Potion Block", "Currently has no working function other than decoration.", TileType<Tiles.DecorBlock.PotionBlocks.GenderChangePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.GenderChangePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class GravitationPotionGlass : QuickTileItem
	{
		public GravitationPotionGlass() : base("Gravitation Potion Block", "Lets you slide upside down\nJump up from the bottom and press up at the right time to slide upside down.", TileType<Tiles.DecorBlock.PotionBlocks.GravitationPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.GravitationPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class HeartreachPotionGlass : QuickTileItem
	{
		public HeartreachPotionGlass() : base("Heartreach Potion Block", "Increases pickup range for life hearts when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.HeartreachPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.HeartreachPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class HunterPotionGlass : QuickTileItem
	{
		public HunterPotionGlass() : base("Hunter Potion Block", "Shows nearby enemies when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.HunterPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.HunterPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class InfernoPotionGlass : QuickTileItem
	{
		public InfernoPotionGlass() : base("Inferno Potion Block", "Ignites nearby enemies when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.InfernoPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.InfernoPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class InvisibilityPotionGlass : QuickTileItem
	{
		public InvisibilityPotionGlass() : base("Invisibility Potion Block", "Grants invisibility and lowers the spawn rate of enemies when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.InvisibilityPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.InvisibilityPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class IronskinPotionGlass : QuickTileItem
	{
		public IronskinPotionGlass() : base("Ironskin Potion Block", "Increased defense by 8 when stood on.\nReduces movement speed when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.IronSkinPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.IronskinPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class LifeforcePotionGlass : QuickTileItem
	{
		public LifeforcePotionGlass() : base("Lifeforce Potion Block", "Increases max life by 20% when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.LifeforcePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.LifeforcePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class LovePotionGlass : QuickTileItem
	{
		public LovePotionGlass() : base("Love Potion Block", "Makes you fall in love with anyone you see when stood on.\n;)", TileType<Tiles.DecorBlock.PotionBlocks.LovePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.LovePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class MagicPowerPotionGlass : QuickTileItem
	{
		public MagicPowerPotionGlass() : base("Magic Power Potion Block", "20% increased magic damage when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.MagicPowerPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.MagicPowerPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class ManaRegenerationPotionGlass : QuickTileItem
	{
		public ManaRegenerationPotionGlass() : base("Mana Regeneration Potion Block", "Increased mana regeneration when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.ManaRegenerationPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.ManaRegenerationPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class MiningPotionGlass : QuickTileItem
	{
		public MiningPotionGlass() : base("Mining Potion Block", "Increases mining speed by 25% when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.MiningPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.MiningPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class NightOwlPotionGlass : QuickTileItem
	{
		public NightOwlPotionGlass() : base("Night Owl Potion Block", "Increases night vision when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.NightOwlPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.NightOwlPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class ObsidianSkinPotionGlass : QuickTileItem
	{
		public ObsidianSkinPotionGlass() : base("Obsidian Skin Potion Block", "Provides immunity to lava when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.ObsidianSkinPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.ObsidianSkinPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class RagePotionGlass : QuickTileItem
	{
		public RagePotionGlass() : base("Rage Potion Block", "Increases critical chance by 10% when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.RagePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.RagePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class RecallPotionGlass : QuickTileItem
	{
		public RecallPotionGlass() : base("Recall Potion Block", "Teleports you home when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.RecallPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.RecallPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe();
		}
	}
	public class RegenerationPotionGlass : QuickTileItem
	{
		public RegenerationPotionGlass() : base("Regeneration Potion Block", "Provides life regeneration when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.RegenerationPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.RegenerationPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class ShinePotionGlass : QuickTileItem
	{
		public ShinePotionGlass() : base("Shine Potion Block", "You emit an aura of light when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.ShinePotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.ShinePotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class SonarPotionGlass : QuickTileItem
	{
		public SonarPotionGlass() : base("Sonar Potion Block", "Detects hooked fish when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.SonarPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.SonarPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class SpelunkerPotionGlass : QuickTileItem
	{
		public SpelunkerPotionGlass() : base("Spelunker Potion Block", "Shows the location of treasure and ore when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.SpelunkerPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.SpelunkerPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class StinkPotionGlass : QuickTileItem
	{
		public StinkPotionGlass() : base("Stink Potion Block", "Makes you smell terrible when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.StinkPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.StinkPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class SummoningPotionGlass : QuickTileItem
	{
		public SummoningPotionGlass() : base("Summoning Potion Block", "Increases your max number of minions by 1 when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.SummonerPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.SummoningPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class SwiftnessPotionGlass : QuickTileItem
	{
		public SwiftnessPotionGlass() : base("Swiftness Potion Block", "25% increased movement speed when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.SwiftnessPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.SwiftnessPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class ThornsPotionGlass : QuickTileItem
	{
		public ThornsPotionGlass() : base("Thorns Potion Block", "Attackers also take damage when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.ThornsPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.ThornsPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class TitanPotionGlass : QuickTileItem
	{
		public TitanPotionGlass() : base("Titan Potion Block", "Increases knockback when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.TitanPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.TitanPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class WarmthPotionGlass : QuickTileItem
	{
		public WarmthPotionGlass() : base("Warmth Potion Block", "Reduced damage from cold sources when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.WarmthPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.WarmthPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class WaterWalkingPotionGlass : QuickTileItem
	{
		public WaterWalkingPotionGlass() : base("Water Walking Potion Block", "Allows the ability to walk on water when stood on.\nDoes it work or not? We'll never know.", TileType<Tiles.DecorBlock.PotionBlocks.WaterWalkingPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.WaterWalkingPotion, 1) ; recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
	public class WrathPotionGlass : QuickTileItem
	{
		public WrathPotionGlass() : base("Wrath Potion Block", "Increases damage by 10% when stood on.", TileType<Tiles.DecorBlock.PotionBlocks.WrathPotionGlassTile>(), 0) { }
		public override void AddRecipes()
		{ ModRecipe recipe = new ModRecipe(mod); recipe.AddIngredient(ItemID.WrathPotion, 1); recipe.AddIngredient(ItemID.Glass, 20); recipe.AddTile(TileID.Bottles); recipe.SetResult(this, 20); recipe.AddRecipe(); }
	}
}
