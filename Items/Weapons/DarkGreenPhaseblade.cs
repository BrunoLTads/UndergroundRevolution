using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.Items.Weapons
{
    public class DarkGreenPhaseblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Green Phaseblade");
            Tooltip.SetDefault("Teste");
        }

        public override void SetDefaults()
        {
            Item.damage = 33;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 25;
            Item.useStyle = 1;
            Item.knockBack = 3;
            Item.value = 27000;
            Item.rare = 1;
            Item.UseSound = SoundID.Item15;
            Item.autoReuse = true;
        }
    }
}