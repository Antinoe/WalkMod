using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace WalkMod
{
    [Label("Server Config")]
    public class WalkModConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static WalkModConfig Instance;
		
	[Header("General")]
		
        [Label("[i:CloudinaBottle] Slow Movement Bug Fix")]
        [Tooltip("If true, fixes the bug where movement-based effects (such as Hermes Boots) apply even when moving slowly.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableMovementBugFix {get; set;}
		
        [Label("[i:HermesBoots] Allow Sprinting")]
        [Tooltip("If false, Players cannot Sprint.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableSprint {get; set;}
		
        [Label("[i:HermesBoots] Sprint Speed")]
        [Tooltip("Additional speed Players attain when Sprinting.\n[Default: 1.5]")]
        [Slider]
        [DefaultValue(1.50f)]
        [Range(1f, 3f)]
        [Increment(0.05f)]
        public float sprintSpeed {get; set;}
		
        [Label("[i:ManaCrystal][i:HermesBoots] Sprinting Consumes Mana")]
        [Tooltip("If true, Sprinting requires Mana to perform.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enableManaSprint {get; set;}
		
        [Label("[i:ManaCrystal] Mana Consumption ")]
        [Tooltip(" of Mana consumed from Sprinting.\n[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(1, 10)]
        [Increment(1)]
        public int manaSprintAmount {get; set;}
		
        [Label("[i:ManaCrystal] Minimum Mana to Sprint")]
        [Tooltip("Minimum  of Mana required to Sprint.\n[Default: 5]")]
        [Slider]
        [DefaultValue(5)]
        [Range(5, 200)]
        [Increment(5)]
        public int manaSprintMinimum {get; set;}
		
        [Label("[i:Tabi] Allow Crawling")]
        [Tooltip("If false, Players cannot Crawl.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableCrawl {get; set;}
		
	[Header("[i:Bed] Resting")]
		
        [Label("[i:LifeCrystal] Laying Down provides Rest.")]
        [Tooltip("If false, Players cannot build up Rest by Laying Down.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableRestLay {get; set;}
		
        [Label("[i:Bed] Maximum Rest")]
        [Tooltip("The maximum Rest Players can have.\n[Default: 3600]")]
        [Slider]
        [DefaultValue(3600)]
        [Range(100, 3600)]
        [Increment(100)]
        public int restMax {get; set;}
		
	[Header("Comfort 1")]
		
        [Label("[i:AlphabetStatue1][i:Campfire] Rest Requirement: Comfort 1")]
        [Tooltip("How much Rest is required to grant the Comfort 1 buff.\n[Default: 600]\n(REQUIRES WORLD RELOAD)")]
        [Slider]
        [DefaultValue(600)]
        [Range(100, 3600)]
        [Increment(100)]
        public int restComfort1 {get; set;}
		
        [Label("[i:AlphabetStatue1][i:Stopwatch] Comfort 1 Time")]
        [Tooltip("How long the Comfort 1 buff lasts.\n[Default: 3600]")]
        [Slider]
        [DefaultValue(3600)]
        [Range(100, 3600)]
        [Increment(100)]
        public int comfort1Time {get; set;}
		
        [Label("[i:AlphabetStatue1][i:CobaltShield] Comfort 1 Defense")]
        [Tooltip("How much Defense the Comfort 1 buff grants.\n[Default: 4]")]
        [Slider]
        [DefaultValue(4)]
        [Range(0, 40)]
        [Increment(1)]
        public int comfort1Defense {get; set;}
		
        [Label("[i:AlphabetStatue1][i:BeetleHusk] Comfort 1 Endurance")]
        [Tooltip("How much Endurance the Comfort 1 buff grants.\n[Default: 0.05f]")]
        [Slider]
        [DefaultValue(0.05f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort1Endurance {get; set;}
		
        [Label("[i:AlphabetStatue1][i:BandofRegeneration] Comfort 1 Regeneration")]
        [Tooltip("How much Life Regeneration the Comfort 1 buff grants.\n[Default: 5]")]
        [Slider]
        [DefaultValue(5)]
        [Range(0, 20)]
        [Increment(1)]
        public int comfort1LifeRegen {get; set;}
		
        [Label("[i:AlphabetStatue1][i:HermesBoots] Comfort 1 Movement Speed")]
        [Tooltip("How much Movement Speed the Comfort 1 buff grants.\n[Default: 0.05f]")]
        [Slider]
        [DefaultValue(0.05)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort1MoveSpeed {get; set;}
		
        [Label("[i:AlphabetStatue1][i:FeralClaws] Comfort 1 Melee Speed")]
        [Tooltip("How much Melee Speed the Comfort 1 buff grants.\n[Default: 0.05f]")]
        [Slider]
        [DefaultValue(0.05)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort1AttackSpeed {get; set;}
		
        [Label("[i:AlphabetStatue1][i:TitanGlove] Comfort 1 Attack Damage")]
        [Tooltip("How much Attack Damage the Comfort 1 buff grants.\n[Default: 0.10f]")]
        [Slider]
        [DefaultValue(0.10)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort1AttackDamage {get; set;}
		
	[Header("Comfort 2")]
		
        [Label("[i:AlphabetStatue2][i:Campfire] Rest Requirement: Comfort 2")]
        [Tooltip("How much Rest is required to grant the Comfort 2 buff.\n[Default: 1200]\n(REQUIRES WORLD RELOAD)")]
        [Slider]
        [DefaultValue(1200)]
        [Range(100, 3600)]
        [Increment(100)]
        public int restComfort2 {get; set;}
		
        [Label("[i:AlphabetStatue2][i:Stopwatch] Comfort 2 Time")]
        [Tooltip("How long the Comfort 2 buff lasts.\n[Default: 1800]")]
        [Slider]
        [DefaultValue(1800)]
        [Range(100, 3600)]
        [Increment(100)]
        public int comfort2Time {get; set;}
		
        [Label("[i:AlphabetStatue2][i:CobaltShield] Comfort 2 Defense")]
        [Tooltip("How much Defense the Comfort 2 buff grants.\n[Default: 6]")]
        [Slider]
        [DefaultValue(6)]
        [Range(0, 40)]
        [Increment(1)]
        public int comfort2Defense {get; set;}
		
        [Label("[i:AlphabetStatue2][i:BeetleHusk] Comfort 2 Endurance")]
        [Tooltip("How much Endurance the Comfort 2 buff grants.\n[Default: 0.10f]")]
        [Slider]
        [DefaultValue(0.10f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort2Endurance {get; set;}
		
        [Label("[i:AlphabetStatue2][i:BandofRegeneration] Comfort 2 Regeneration")]
        [Tooltip("How much Life Regeneration the Comfort 2 buff grants.\n[Default: 5]")]
        [Slider]
        [DefaultValue(5)]
        [Range(0, 20)]
        [Increment(1)]
        public int comfort2LifeRegen {get; set;}
		
        [Label("[i:AlphabetStatue2][i:HermesBoots] Comfort 2 Movement Speed")]
        [Tooltip("How much Movement Speed the Comfort 2 buff grants.\n[Default: 0.05f]")]
        [Slider]
        [DefaultValue(0.05)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort2MoveSpeed {get; set;}
		
        [Label("[i:AlphabetStatue2][i:FeralClaws] Comfort 2 Melee Speed")]
        [Tooltip("How much Melee Speed the Comfort 2 buff grants.\n[Default: 0.05f]")]
        [Slider]
        [DefaultValue(0.05)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort2AttackSpeed {get; set;}
		
        [Label("[i:AlphabetStatue2][i:TitanGlove] Comfort 2 Attack Damage")]
        [Tooltip("How much Attack Damage the Comfort 2 buff grants.\n[Default: 0.10f]")]
        [Slider]
        [DefaultValue(0.10)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float comfort2AttackDamage {get; set;}
    }
}