using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.UI;


namespace WalkMod
{
	public class WalkMod : Mod
	{
		public static ModKeybind WalkToggle;
		public static ModKeybind WalkHold;
		public static ModKeybind WalkFast;
		public static ModKeybind Run;
		public static ModKeybind Sprint;
		public static ModKeybind WalkModeFaster;
		public static ModKeybind WalkModeSlower;
		public static ModKeybind CrawlToggle;
		//public static ModKeybind SitToggle;
		public static ModKeybind LayToggle;
		
        public override void Load()
        {
            WalkToggle = KeybindLoader.RegisterKeybind(this, "Toggle Walk", "C");
            WalkHold = KeybindLoader.RegisterKeybind(this, "Hold Walk", "LeftAlt");
            WalkFast = KeybindLoader.RegisterKeybind(this, "Fast Walk", "LeftShift");
            Run = KeybindLoader.RegisterKeybind(this, "Run", "LeftShift");
            Sprint = KeybindLoader.RegisterKeybind(this, "Sprint", "LeftControl");
            WalkModeFaster = KeybindLoader.RegisterKeybind(this, "Walk Faster", "X");
            WalkModeSlower = KeybindLoader.RegisterKeybind(this, "Walk Slower", "Z");
            CrawlToggle = KeybindLoader.RegisterKeybind(this, "Toggle Crawl", "LeftControl");
            //SitToggle = KeybindLoader.RegisterKeybind(this, "Sit Down", "RightAlt");
            LayToggle = KeybindLoader.RegisterKeybind(this, "Lay Down", "RightAlt");
        }
        
        public override void Unload()
        {
            WalkToggle = null;
            WalkHold = null;
            WalkFast = null;
            WalkModeFaster = null;
            WalkModeSlower = null;
            Run = null;
            Sprint = null;
            CrawlToggle = null;
            //SitToggle = null;
            LayToggle = null;
        }
    }
}