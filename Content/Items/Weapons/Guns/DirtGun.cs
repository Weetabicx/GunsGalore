using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

using GunsGalore.Content.Projectiles;

namespace GunsGalore.Content.Items.Weapons.Guns

{
    public class DirtGun : ModItem 
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fires shit at got speed!");
        }

        public override void SetDefaults()
        {
            // Base properties
            Item.width = 62;
            Item.height = 32;
            Item.scale = 0.8f;
            Item.rare = ItemRarityID.Blue;

            // Combat properties
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 15;

            // User properties
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;

            // Gun properties 
            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 16f;

            // Special ammo for this little guy
            Item.useAmmo = AmmoID.Bullet;

        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(1);
            recipe.AddIngredient(ItemID.FlintlockPistol, 1);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}