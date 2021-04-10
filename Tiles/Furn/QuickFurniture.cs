using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using System;
using Terraria.Enums;
using Terraria.Localization;

namespace DecoTiles.Tiles.Furn
{
	/*
	int width = newTile.Width
	int height = newTile.Height
	int[] coord = new int[] { 16, 16 };
	bool rotate = does it flip
	Point16 cursorPlace = new Point16(x, y);
	 */
	public abstract class QuickBench : ModTile
    {
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickBench(string mapname, int dust, bool lavaKill, int drop)
        {
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
        }
        public override void SetDefaults()
        {
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new[] { 18 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = numbDust;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.WorkBenches };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
	public abstract class QuickBath : ModTile
    {
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickBath(string mapname, int dust, bool lavaKill, int drop)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
		}

		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			TileObjectData.newTile.Width = 4;
			TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
			TileObjectData.addTile(Type);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = numbDust;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Bathtubs };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 64, 32, dropItem);
		}
	}
	public abstract class QuickBed : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickBed(string mapname, int dust, bool lavaKill, int drop)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
		}

		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			TileID.Sets.HasOutlines[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
			TileObjectData.newTile.Width = 4;
			TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = numbDust;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Beds };
			bed = true;
		}
		public override bool HasSmartInteract()
		{
			return true;
		}
		public override bool NewRightClick(int i, int j)
		{
			Player player = Main.LocalPlayer;
			Tile tile = Main.tile[i, j];
			int spawnX = i - tile.frameX / 18;
			int spawnY = j + 2;
			spawnX += tile.frameX >= 72 ? 5 : 2;
			if (tile.frameY % 38 != 0)
			{
				spawnY--;
			}
			player.FindSpawn();
			if (player.SpawnX == spawnX && player.SpawnY == spawnY)
			{
				player.RemoveSpawn();
				Main.NewText("Spawn point removed!", 255, 240, 20, false); 
			}
			else if (Player.CheckSpawn(spawnX, spawnY))
			{
				player.ChangeSpawn(spawnX, spawnY);
				Main.NewText("Spawn point set!", 255, 240, 20, false);
			}
			return true;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 64, 32, dropItem);
		}

		public override void MouseOver(int i, int j)
		{
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.showItemIcon = true;
			player.showItemIcon2 = dropItem;
		}
	}
	public abstract class QuickBookcase : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickBookcase(string mapname, int dust, bool lavaKill, int drop)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 18 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = numbDust;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Bookcases };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
	public abstract class QuickCandelabra : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly bool waterKillType;
		private readonly int dropItem;

		public QuickCandelabra(string mapname, int dust, bool lavaKill, int drop, bool waterKill)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			waterKillType = waterKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileWaterDeath[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.WaterDeath = true;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			adjTiles = new int[] { TileID.Candelabras };
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			Tile tile = Main.tile[i, j];
			if (tile.frameX == 0)
			{
				r = 1f;
				g = 0.75f;
				b = 1f;
			}
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
	public abstract class QuickCandle : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly bool waterKillType;
		private readonly int dropItem;

		public QuickCandle(string mapname, int dust, bool lavaKill, int drop, bool waterKill)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			waterKillType = waterKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileWaterDeath[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			drop = dropItem;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.WaterDeath = true;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			adjTiles = new int[] { TileID.Candles };
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			Tile tile = Main.tile[i, j];
			if (tile.frameX == 0)
			{
				r = 1f;
				g = 0.75f;
				b = 1f;
			}
		}
	}
	public abstract class QuickChair : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickChair(string mapname, int dust, bool lavaKill, int drop)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = numbDust;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Chairs };
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
	public abstract class QuickChest : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;

		public QuickChest(string mapname, int dust, bool lavaKill, int drop)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = true;
			Main.tileContainer[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileValue[Type] = 500;
			TileID.Sets.HasOutlines[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
			TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
			TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = lavaKillType;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Containers };
			chest = mapName;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
		public override bool HasSmartInteract()
		{
			return true;
		}
		public string MapChestName(string name, int i, int j)
		{
			int left = i;
			int top = j;
			Tile tile = Main.tile[i, j];
			if (tile.frameX % 54 != 0)
			{
				left--;
			}
			if (tile.frameY % 54 != 0)
			{
				top--;
			}
			int chest = Chest.FindChest(left, top);
			if (Main.chest[chest].name == mapName)
			{
				return name;
			}
			else
			{
				return name + ": " + Main.chest[chest].name;
			}
		}
		public override void RightClick(int i, int j)
		{
			Player player = Main.LocalPlayer;
			Tile tile = Main.tile[i, j];
			Main.mouseRightRelease = false;
			int left = i;
			int top = j;
			if (tile.frameX % 36 != 0)
			{
				left--;
			}
			if (tile.frameY % 36 != 0)
			{
				top--;
			}
			if (player.sign >= 0)
			{
				Main.PlaySound(SoundID.MenuClose);
				player.sign = -1;
				Main.editSign = false;
				Main.npcChatText = "";
			}
			if (Main.editChest)
			{
				Main.PlaySound(SoundID.MenuTick);
				Main.editChest = false;
				Main.npcChatText = "";
			}
			if (player.editedChestName)
			{
				NetMessage.SendData(33, -1, -1, NetworkText.FromLiteral(Main.chest[player.chest].name), player.chest, 1f, 0f, 0f, 0, 0, 0);
				player.editedChestName = false;
			}
			if (Main.netMode == 1)
			{
				if (left == player.chestX && top == player.chestY && player.chest >= 0)
				{
					player.chest = -1;
					Recipe.FindRecipes();
					Main.PlaySound(SoundID.MenuClose);
				}
				else
				{
					NetMessage.SendData(31, -1, -1, null, left, (float)top, 0f, 0f, 0, 0, 0);
					Main.stackSplit = 600;
				}
			}
			else
			{
				int chest = Chest.FindChest(left, top);
				if (chest >= 0)
				{
					Main.stackSplit = 600;
					if (chest == player.chest)
					{
						player.chest = -1;
						Main.PlaySound(SoundID.MenuClose);
					}
					else
					{
						player.chest = chest;
						Main.playerInventory = true;
						Main.recBigList = false;
						player.chestX = left;
						player.chestY = top;
						Main.PlaySound(player.chest < 0 ? SoundID.MenuOpen : SoundID.MenuTick);
					}
					Recipe.FindRecipes();
				}
			}
		}
		public override void MouseOver(int i, int j)
		{
			Player player = Main.LocalPlayer;
			Tile tile = Main.tile[i, j];
			int left = i;
			int top = j;
			if (tile.frameX % 54 != 0)
			{
				left--;
			}
			if (tile.frameY % 54 != 0)
			{
				top--;
			}
			int chest = Chest.FindChest(left, top);
			player.showItemIcon2 = -1;
			if (chest < 0)
			{
				player.showItemIconText = Language.GetTextValue("LegacyChestType.0");
			}
			else
			{
				player.showItemIconText = Main.chest[chest].name.Length > 0 ? Main.chest[chest].name : mapName;
				if (player.showItemIconText == mapName)
				{
					player.showItemIcon2 = dropItem;
					player.showItemIconText = "";
				}
			}
			player.noThrow = 2;
			player.showItemIcon = true;
		}
		public override void MouseOverFar(int i, int j)
		{
			MouseOver(i, j);
			Player player = Main.LocalPlayer;
			if (player.showItemIconText == mapName)
			{
				player.showItemIcon = false;
				player.showItemIcon2 = 0;
			}
		}
	}
	public abstract class QuickChandelier : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly bool waterKillType;
		private readonly int dropItem;

		public QuickChandelier(string mapname, int dust, bool lavaKill, int drop, bool waterKill)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			waterKillType = waterKill;
			dropItem = drop;
		}
		public override void SetDefaults()
		{
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileWaterDeath[Type] = true;
			Main.tileLavaDeath[Type] = lavaKillType;

			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.Width = 3;
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
			TileObjectData.newTile.WaterDeath = true;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault(mapName);
			AddMapEntry(new Color(200, 200, 200), name);
			adjTiles = new int[] { TileID.Candelabras };
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			Tile tile = Main.tile[i, j];
			if (tile.frameX == 0)
			{
				r = 1f;
				g = 0.75f;
				b = 1f;
			}
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
	public abstract class QuickCustom : ModTile
	{
		public string mapName;
		private readonly int numbDust;
		private readonly bool lavaKillType;
		private readonly int dropItem;
		private readonly int tileWidth;
		private readonly int tileHeight;
		private readonly int[] coordHeight;
		private bool doesRotate;
		private Point16 placeTile;

		public QuickCustom(string mapname, int dust, bool lavaKill, int drop, int width, int height, int[] coord, bool rotate, Point16 cursorPlace)
		{
			mapName = mapname;
			numbDust = dust;
			lavaKillType = lavaKill;
			dropItem = drop;
			tileWidth = width;
			tileHeight = height;
			coordHeight = coord;
			doesRotate = rotate;
			placeTile = cursorPlace;

		}
		public override void SetDefaults()
		{
			TileObjectData.newTile = new TileObjectData(TileObjectData.Style2xX);
			if (doesRotate == true)
			{
				Main.tileFrameImportant[Type] = true;
				Main.tileNoAttach[Type] = true;
				Main.tileLavaDeath[Type] = lavaKillType;

				TileObjectData.newTile.UsesCustomCanPlace = true;
				TileObjectData.newTile.DrawFlipHorizontal = true;
				TileObjectData.newTile.StyleHorizontal = true;
				TileObjectData.newTile.Height = tileHeight;
				TileObjectData.newTile.Width = tileWidth;
				TileObjectData.newTile.CoordinateHeights = coordHeight;

				TileObjectData.newTile.CopyFrom(TileObjectData.newTile);
				TileObjectData.newTile.Origin = placeTile;
				TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
				TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;

				TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
				TileObjectData.newAlternate.Origin = placeTile;
				TileObjectData.newAlternate.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
				TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
				TileObjectData.addAlternate(1);
				TileObjectData.addTile(Type);
				ModTranslation name = CreateMapEntryName();
				name.SetDefault(mapName);
				AddMapEntry(new Color(200, 200, 200), name);
				dustType = numbDust;
			}
            else
            {
				Main.tileSolidTop[Type] = false;
				Main.tileFrameImportant[Type] = true;
				Main.tileNoAttach[Type] = true;
				Main.tileLavaDeath[Type] = lavaKillType;
				TileObjectData.newTile.Height = tileHeight;
				TileObjectData.newTile.Width = tileWidth;
				TileObjectData.newTile.CoordinateHeights = coordHeight;
				TileObjectData.newTile.UsesCustomCanPlace = true;
				TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
				TileObjectData.addTile(Type);
				TileObjectData.newTile.Origin = placeTile;
				ModTranslation name = CreateMapEntryName();
				name.SetDefault(mapName);
				AddMapEntry(new Color(200, 200, 200), name);
				dustType = numbDust;
			}

		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, dropItem);
		}
	}
}
