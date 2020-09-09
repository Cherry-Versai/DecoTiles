using Terraria.ModLoader.Config;
using DecoTiles;

namespace DecoTiles.Config
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("New dungeons")]
        [Tooltip("Enables new colours for the dungeon. NOTE: This may mess with some mods dungeon generation but it should be fine.")]
        public bool CherryDungeons = true;

    }
}