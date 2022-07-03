using Terraria;
using Terraria.ModLoader;

namespace WalkMod.Content.Buffs
{
	public class Comfort2 : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Well Rested");
			Description.SetDefault("You are well-rested.\n" + "Your Physical Fortitude has been moderately increased.");
		}
		
		public override void Update(Player Player, ref int buffIndex)
		{
			Player.statDefense += WalkModConfig.Instance.comfort2Defense;
			Player.endurance += WalkModConfig.Instance.comfort2Endurance;
			Player.lifeRegen += WalkModConfig.Instance.comfort2LifeRegen;
			Player.GetAttackSpeed(DamageClass.Melee) += WalkModConfig.Instance.comfort2AttackSpeed;
			Player.GetDamage(DamageClass.Generic) += WalkModConfig.Instance.comfort2AttackDamage;
			Player.moveSpeed += WalkModConfig.Instance.comfort2MoveSpeed;
		}
		
		/*public override void PostUpdateRunSpeeds()
		{
		}*/
	}
}