using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThrowingTables.Projectiles {
    public class TableProjectile : ModProjectile {
        public override void SetDefaults() {
            projectile.CloneDefaults(ProjectileID.ThrowingKnife);
            projectile.name = "Throwing Table";
            projectile.width = 48;
            projectile.height = 34;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 10;
            projectile.timeLeft = 1000;
            projectile.light = 0.5f;
            projectile.aiStyle = 1;
        }

        public override void Kill(int timeLeft) {
            Main.PlaySound(SoundID.Item1, projectile.position);
        }
    }
}
