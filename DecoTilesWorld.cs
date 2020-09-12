using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;
using static Terraria.ModLoader.ModContent;
using System.Linq;
using DecoTiles.Configs;
namespace DecoTiles
{
    public class DecoTilesWorld : ModWorld
    {

        int[] DungeonBricks = { TileID.BlueDungeonBrick, TileID.PinkDungeonBrick, TileID.GreenDungeonBrick};
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            if (GetInstance<Config>().CherryDungeons)
            {
                tasks.Add(new PassLegacy("New Dungeons", delegate (GenerationProgress progress)
                {
                    for (int i = 0; i < Main.maxTilesX - 1; ++i)
                        for (int j = 0; j < Main.maxTilesY - 200; ++j)
                        {
                            Tile Block = Framing.GetTileSafely(i, j);
                            if (DungeonBricks.Any(x => x == Block.type))
                                Main.tile[i, j].type = (ushort)ModContent.TileType<Tiles.DecorBlock.BlackBrickTile>(); 
                            { };
                        }

                }));
            }

        }
    }
}
/*
for (int i = 20; i<Main.maxTilesX - 20; ++i) 
{
  for (int j = 20; j<Main.maxTilesY - 200; ++j)
  {
    if (Framing.GetTileSafely(i, j).type == TileID.BlueDungeonBrick) 
      Main.tile[i, j].type = CustomBrickType;
  }
} */