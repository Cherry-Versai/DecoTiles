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


namespace DecoTiles.Tiles.Furn.Misc.Fountains
{

    public class SpaceFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] {16, 16, 16, 16};
            animationFrameHeight = 72;
            name.SetDefault("Space Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class HiveFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Hive Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class GraniteFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Granite Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class HellFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Hell Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class MarbleFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Marble Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class TempleFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Temple Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
    public class UndIceFountainTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            ModTranslation name = CreateMapEntryName();
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16 };
            animationFrameHeight = 72;
            name.SetDefault("Underground Ice Water Fountain");
            TileObjectData.addTile(Type);
            adjTiles = new int[] { TileID.WaterFountain };
        }
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frame = Main.tileFrame[TileID.WaterFountain];
            frameCounter = Main.tileFrameCounter[TileID.WaterFountain];
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];
            Texture2D texture;
            if (Main.canDrawColorTile(i, j))
            {
                texture = Main.tileAltTexture[Type, tile.color()];
            }
            else
            {
                texture = Main.tileTexture[Type];
            }
            Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
            if (Main.drawToScreen)
            {
                zero = Vector2.Zero;
            }
            int animate = 0;
            if (tile.frameY >= 72)
            {
                animate = Main.tileFrame[Type] * animationFrameHeight;
            }
            Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY + animate, 16, 16), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);
            return false;
        }
        public override bool HasSmartInteract()
        {
            return true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("ass"));
        }
        public override bool NewRightClick(int i, int j)
        {
            Main.PlaySound(SoundID.Mech, i * 16, j * 16, 0);
            HitWire(i, j);
            return true;
        }

        public override void HitWire(int i, int j)
        {
            int x = i - (Main.tile[i, j].frameX / 18) % 2;
            int y = j - (Main.tile[i, j].frameY / 18) % 4;
            for (int l = x; l < x + 2; l++)
            {
                for (int m = y; m < y + 4; m++)
                {
                    if (Main.tile[l, m] == null)
                    {
                        Main.tile[l, m] = new Tile();
                    }
                    if (Main.tile[l, m].active() && Main.tile[l, m].type == Type)
                    {
                        if (Main.tile[l, m].frameY < 72)
                        {
                            Main.tile[l, m].frameY += 72;
                        }
                        else
                        {
                            Main.tile[l, m].frameY -= 72;
                        }
                    }
                }
            }
            if (Wiring.running)
            {
                Wiring.SkipWire(x, y);
                Wiring.SkipWire(x, y + 1);
                Wiring.SkipWire(x, y + 2);
                Wiring.SkipWire(x, y + 3);
                Wiring.SkipWire(x + 1, y);
                Wiring.SkipWire(x + 1, y + 1);
                Wiring.SkipWire(x + 1, y + 2);
                Wiring.SkipWire(x + 1, y + 3);
            }
            NetMessage.SendTileSquare(-1, x, y + 1, 3);
        }
    }
}

