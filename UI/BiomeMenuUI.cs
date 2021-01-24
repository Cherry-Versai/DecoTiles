using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace DecoTiles.UI
{
    internal class BiomeMenuUI : UIState
    {
        public DragableUIPanel BiomeSelect;
        public static bool Visible;

        public override void OnInitialize()
        {
            BiomeSelect = new DragableUIPanel();
            BiomeSelect.SetPadding(0);
            // We need to place this UIElement in relation to its Parent. Later we will be calling `base.Append(coinCounterPanel);`. 
            // This means that this class, ExampleUI, will be our Parent. Since ExampleUI is a UIState, the Left and Top are relative to the top left of the screen.
            BiomeSelect.Left.Set(400f, 0f);
            BiomeSelect.Top.Set(100f, 0f);
            BiomeSelect.Width.Set(170f, 0f);
            BiomeSelect.Height.Set(70f, 0f);
            BiomeSelect.BackgroundColor = new Color(73, 94, 171);


            Texture2D buttonPlayTexture = ModContent.GetTexture("Terraria/UI/ButtonPlay");
            UIHoverImageButton playButton = new UIHoverImageButton(buttonPlayTexture, "Reset Coins Per Minute Counter");
            playButton.Left.Set(110, 0f);
            playButton.Top.Set(10, 0f);
            playButton.Width.Set(22, 0f);
            playButton.Height.Set(22, 0f);
            // UIHoverImageButton doesn't do anything when Clicked. Here we assign a method that we'd like to be called when the button is clicked.
            //playButton.OnClick += new MouseEvent();
            //BiomeSelect.Append(playButton);
        }
    }
}