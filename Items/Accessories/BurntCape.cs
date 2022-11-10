using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.Items.Accessories
{
    public class BurntCape : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Don't even think about wearing this\n"
                                + "Helps you agains't fire");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.accessory = true;
            Item.maxStack = 1;
            Item.value = Item.sellPrice(gold: 5);
            Item.rare = ItemRarityID.Blue;
        }
    }
}