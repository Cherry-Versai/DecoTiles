using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria;
using Terraria.ModLoader;

namespace DecoTiles.UI
{
    class BiomeButton : UIElement
    {
        Color color = new Color(50, 255, 153);
    }
    class BiomeMenu : UIState
    {
        public BiomeButton biomeButton;

        public override void OnInitialize()
        {
            biomeButton = new BiomeButton();

            Append(biomeButton);
        }
    }
}

