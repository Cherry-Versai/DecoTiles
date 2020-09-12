using Terraria.ModLoader.Config;
using DecoTiles;

namespace DecoTiles.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("New dungeons")]
        [Tooltip("Enables new colours for the dungeon. \nNOTE: This may mess with some mods dungeon generation but it should be fine.")]
        public bool CherryDungeons = true;

    }
}