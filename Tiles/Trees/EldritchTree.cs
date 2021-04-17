using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DecoTiles.Tiles.Trees
{
	public class DecoTiles : ModTree
	{
		private Mod mod => ModLoader.GetMod("DecoTiles");

		public override int DropWood()
		{
            return ItemType<Items.DecorBlockItem.OfficeFloor>();
        }

		public override Texture2D GetTexture()
		{
            return mod.GetTexture("Tiles/Trees/EldritchTree");
        }

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
            return mod.GetTexture("Tiles/Trees/EldritchTree_Tops");
        }

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
            return mod.GetTexture("Tiles/Trees/EldritchTree_Branches");
        }
	}
}