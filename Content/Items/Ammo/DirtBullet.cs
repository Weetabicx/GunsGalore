using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GunsGalore.Content.Items.Ammo
{
	public class DirtBullet : ModItem
	{

		public override void SetDefaults() {
			Item.damage = 3; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.DirtBullet>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 16f; // The speed of the projectile.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe(25)
				.AddIngredient(ItemID.DirtBlock, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}