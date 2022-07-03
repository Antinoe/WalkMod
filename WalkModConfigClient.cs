using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace WalkMod
{
    [Label("Client Config")]
    public class WalkModConfigClient : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static WalkModConfigClient Instance;
		
	[Header("General")]
		
        [Label("[i:Megaphone] Enable Toggle Sounds")]
        [Tooltip("If false, sounds will not play upon toggling Walk on/off.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enableToggleSounds {get; set;}
		
        [Label("[i:Megaphone] Enable Press Sounds")]
        [Tooltip("If false, sounds will not play upon pressing the Increase/Decrease Walk Speed keybinds.\n[Default: On]")]
        [DefaultValue(true)]
        public bool enablePressSounds {get; set;}
		
        [Label("[i:HermesBoots] Fast Walk Speed")]
        [Tooltip("Additional Walk Speed you gain when holding the Fast Walk keybind.\n[Default: 3]")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 9)]
        [Increment(1)]
        public int walkFastSpeed {get; set;}
		
        [Label("[i:Bed] Lay Body Frame")]
        [Tooltip("Body Frame to use when laying down.\n[Default: 15]")]
        [Slider]
        [DefaultValue(15)]
        [Range(1, 19)]
        [Increment(1)]
        public int layBodyFrame {get; set;}
		
        [Label("[i:Bed] Lay Leg Frame")]
        [Tooltip("Leg Frame to use when laying down.\n[Default: 15]")]
        [Slider]
        [DefaultValue(15)]
        [Range(1, 19)]
        [Increment(1)]
        public int layLegFrame {get; set;}
		
	[Header("Walk Speeds")]
		
        [Label("10% Walk Speed")]
        [Tooltip("[Default: 0.1]")]
        [Slider]
        [DefaultValue(0.1f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed1 {get; set;}
		
        [Label("20% Walk Speed")]
        [Tooltip("[Default: 0.2]")]
        [Slider]
        [DefaultValue(0.2f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed2 {get; set;}
		
        [Label("30% Walk Speed")]
        [Tooltip("[Default: 0.3]")]
        [Slider]
        [DefaultValue(0.3f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed3 {get; set;}
		
        [Label("40% Walk Speed")]
        [Tooltip("[Default: 0.4]")]
        [Slider]
        [DefaultValue(0.4f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed4 {get; set;}
		
        [Label("50% Walk Speed")]
        [Tooltip("[Default: 0.5]")]
        [Slider]
        [DefaultValue(0.5f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed5 {get; set;}
		
        [Label("60% Walk Speed")]
        [Tooltip("[Default: 0.6]")]
        [Slider]
        [DefaultValue(0.6f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed6 {get; set;}
		
        [Label("70% Walk Speed")]
        [Tooltip("[Default: 0.7]")]
        [Slider]
        [DefaultValue(0.7f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed7 {get; set;}
		
        [Label("80% Walk Speed")]
        [Tooltip("[Default: 0.8]")]
        [Slider]
        [DefaultValue(0.8f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed8 {get; set;}
		
        [Label("90% Walk Speed")]
        [Tooltip("[Default: 0.9]")]
        [Slider]
        [DefaultValue(0.9f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed9 {get; set;}
		
        [Label("95% Walk Speed")]
        [Tooltip("[Default: 0.95]")]
        [Slider]
        [DefaultValue(0.95f)]
        [Range(0.05f, 0.95f)]
        [Increment(0.05f)]
        public float walkSpeed10 {get; set;}
		
    }
}