using Terraria;
using Terraria.ModLoader;

namespace WalkMod.Content.Buffs
{
	public class Comfort1 : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rested");
			Description.SetDefault("You are rested.\n" + "Your Physical Fortitude has been slightly increased.");
		}
		
		public override void Update(Player Player, ref int buffIndex)
		{
			Player.statDefense += WalkModConfig.Instance.comfort1Defense;
			Player.endurance += WalkModConfig.Instance.comfort1Endurance;
			Player.lifeRegen += WalkModConfig.Instance.comfort1LifeRegen;
			Player.GetAttackSpeed(DamageClass.Melee) += WalkModConfig.Instance.comfort2AttackSpeed;
			Player.GetDamage(DamageClass.Generic) += WalkModConfig.Instance.comfort2AttackDamage;
			Player.moveSpeed += WalkModConfig.Instance.comfort1MoveSpeed;
		}
		
		/*public override void PostUpdateRunSpeeds()
		{
		}*/
	}
}