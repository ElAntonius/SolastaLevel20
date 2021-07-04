using UnityModManagerNet;
using ModKit;

namespace SolastaLevel20.Viewers
{
    public class SettingsViewer : IMenuSelectablePage
    {
        public string Name => "Settings";

        public int Priority => 0;

        private static void DisplaySettings()
        {
            bool toggle;

            UI.Label("Welcome to Level 20".yellow().bold());
            UI.Div();

            UI.Label("Enables / Disables adding missing features to game official classes above level 10:");

            toggle = Main.Settings.enableClericProgression;
            if (UI.Toggle("Cleric", ref toggle, 0, UI.AutoWidth())) 
            {
                Main.Settings.enableClericProgression = toggle;
            }

            toggle = Main.Settings.enableFighterProgression;
            if (UI.Toggle("Fighter", ref toggle, 0, UI.AutoWidth()))
            {
                Main.Settings.enableFighterProgression = toggle;
            }

            toggle = Main.Settings.enablePaladinProgression;
            if (UI.Toggle("Paladin", ref toggle, 0, UI.AutoWidth()))
            {
                Main.Settings.enablePaladinProgression = toggle;
            }

            toggle = Main.Settings.enableRangerProgression;
            if (UI.Toggle("Ranger", ref toggle, 0, UI.AutoWidth()))
            {
                Main.Settings.enableRangerProgression = toggle;
            }

            toggle = Main.Settings.enableRogueProgression;
            if (UI.Toggle("Rogue", ref toggle, 0, UI.AutoWidth()))
            {
                Main.Settings.enableRogueProgression = toggle;
            }

            toggle = Main.Settings.enableWizardProgression;
            if (UI.Toggle("Wizard", ref toggle, 0, UI.AutoWidth()))
            {
                Main.Settings.enableWizardProgression = toggle;
            }
        }

        public void OnGUI(UnityModManager.ModEntry modEntry)
        {
            if (Main.Mod == null) return;

            DisplaySettings();
        }
    }
}