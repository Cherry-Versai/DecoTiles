using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DecoTiles.Items;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.GameContent.UI.States;
using IL.Terraria.IO;
using System.Collections.Generic;
using System;
using Terraria.Graphics.Shaders;

namespace DecoTiles.Projectiles
{
    public class LesbianBullet : ModProjectile
    {
        public override void SetDefaults()
        {
			projectile.width = 10;
			projectile.height = 10;
			projectile.timeLeft = 1000;
			projectile.penetrate = -1;
			projectile.extraUpdates = 1;
			projectile.friendly = false;
            projectile.tileCollide = true;
            projectile.damage = 2;
			projectile.ranged = true;
			projectile.ignoreWater = false;
			projectile.scale = 1f;
		}
        public override void AI()
        {

            float rot = Vector2.Normalize(projectile.velocity).ToRotation();
            float radius = 10 * projectile.scale;
            float angle = (float)projectile.timeLeft / 5;
            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    angle += 3.14f;
                }
                float x = projectile.Center.X + (float)Math.Sin(rot) * ((float)Math.Sin(angle) * radius);
                float y = projectile.Center.Y + (float)Math.Cos(rot) * ((float)Math.Sin(angle) * -radius);
                Vector2 orbitPos = new Vector2(x, y);
                Dust orbit = Dust.NewDustPerfect(orbitPos, 272, -projectile.velocity * 0.1f, Main.rand.Next(100, 175), default, Main.rand.NextFloat(0.5f, 0.8f));
                orbit.noGravity = true;
                orbit.scale += projectile.scale;
                orbit.color = new Color(211, 86, 119);

                orbit.noGravity = true;
                orbit.shader = GameShaders.Armor.GetSecondaryShader(77, Main.LocalPlayer);
                orbit.fadeIn = 2.210526f;

            }
        }
    }
}