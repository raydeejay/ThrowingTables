using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThrowingTables.Items {
    public class ThrowingTable : ModItem {
        public override void SetDefaults() {
            item.name = "Throwing Table";
            item.toolTip = "Vent out your rage!";
            item.width = 48;
            item.height = 34;
            item.value = 100;
            item.maxStack = 999;
            item.rare = 2;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.noUseGraphic = true;
            item.damage = 20;
            item.knockBack = 6;
            item.noMelee = true;
            item.thrown = true;
            item.autoReuse = true;
            item.consumable = true;
            item.shoot = mod.ProjectileType("TableProjectile");
            item.shootSpeed = 16f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            Vector2 speed = new Vector2(speedX, speedY);
            speed = speed.RotatedByRandom(MathHelper.ToRadians(45));
            speedX = (30 + Main.rand.Next(-10, 6)) / 10.0f * (speed.X > 0 ? 1 : -1);
            speedY = -5;
            position.Y -= 16;
            return true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenTable, 25);
            recipe.AddIngredient(ItemID.CopperOre, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenTable, 25);
            recipe.AddIngredient(ItemID.TinOre, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 25);
            recipe.AddRecipe();
        }
    }
}
