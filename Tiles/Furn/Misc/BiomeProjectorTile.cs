using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework.Graphics;
using DecoTiles.UI;


namespace DecoTiles.Tiles.Furn.Misc
{

    public class BiomeProjectorTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileSolidTop[Type] = false;

            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile = new TileObjectData(TileObjectData.Style2xX);
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16};
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CopyFrom(TileObjectData.newTile);
            TileObjectData.newTile.Origin = new Point16(1, 3);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);

            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            AddMapEntry(new Color(199, 177, 152));
            dustType = 261;

        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("BiomeProjector"));
        }

        public override bool NewRightClick(int i, int j)
        {
            BiomeMenuUI.Visible = true;
            return true;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
    }
}