using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;

namespace LRPMod.Items
{
    public class LuxGladius: ModItem
			{
			   public override void UseItemEffects(Player player, Rectangle rectangle)
                {
                        int dustID = Dust.NewDust(new Vector2((float)rectangle.X, (float)rectangle.Y), rectangle.Width, rectangle.Height, 13, (player.velocity.X * 0.2f) + (player.direction * 3), player.velocity.Y * 0.2f, 100, Color.White, 0.8f + (Main.rand.Next(6) * 0.1f));
                        Main.dust[dustID].noGravity = true;
                }
			}
		}