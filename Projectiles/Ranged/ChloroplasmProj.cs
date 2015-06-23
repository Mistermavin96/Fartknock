using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace LRPMod.Projectiles
{
    public class ChloroplasmProj : ModProjectile
	{
		public override void AI()
		{
			Player owner = Main.player[projectile.owner];
			projectile.light = 0.9f;
			projectile.alpha = 128;
			projectile.rotation += (float)projectile.direction * 0.8f;
			int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f);
			Main.dust[DustID].noGravity = true;
		}
		
		public override void DealtNPC(NPC n, int hitDir, int dmgDealt, float knockback, bool crit)
		{
			Player owner = Main.player[projectile.owner];
			owner.statLife += (dmgDealt / 30);
		}
	}
}