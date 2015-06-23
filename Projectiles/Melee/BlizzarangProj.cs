using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;
namespace LRPMod.Projectiles
{
    
	public class BlizzarangProj : ModProjectile
	{
		
		public override void AI()
		{
			projectile.light = 0.9f; //LIGHT!
			projectile.rotation += (float)projectile.direction * 0.8f; //ROTATIONS!
			int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f); //DUST!
			Main.dust[DustID].noGravity = true;	//ANTIGRAVITY DUST!!
			
        }
		
	}
	
}