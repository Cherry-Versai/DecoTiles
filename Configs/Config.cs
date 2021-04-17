using Terraria.ModLoader.Config;
using DecoTiles;

namespace DecoTiles.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("New dungeons")]
        [Tooltip("Enables new colours for the dungeon. \nNOTE: This may mess with some mods dungeon generation and any additions.")]
        public bool CherryDungeons = true;

        [Label("Microstructures")]
        [Tooltip("Enables the generation of a select few microstructures across the world.")]
        public bool MiniStructures = true;

    }
}