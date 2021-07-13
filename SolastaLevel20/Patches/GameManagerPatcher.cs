using HarmonyLib;
using SolastaLevel20.Models.Classes;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    class GameManagerPatcher
    {
        internal static void FixExperienceTable()
        {
            int[] experienceThresholds = new int[21];
            experienceThresholds[MOD_MAX_LEVEL] = MAX_CHARACTER_EXPERIENCE;
            for (var ix = 0; ix < MOD_MAX_LEVEL; ix++)
            {
                experienceThresholds[ix] = RuleDefinitions.ExperienceThresholds[ix];
            }
            RuleDefinitions.ExperienceThresholds = experienceThresholds;
        }

        [HarmonyPatch(typeof(GameManager), "BindPostDatabase")]
        internal static class GameManager_BindPostDatabase_Patch
        {
            internal static void Postfix()
            {
                FixExperienceTable();

                if (Main.Settings.enableClericProgression) ClericBuilder.Load();
                if (Main.Settings.enableFighterProgression) FighterBuilder.Load();
                if (Main.Settings.enablePaladinProgression) PaladinBuilder.Load();
                if (Main.Settings.enableRangerProgression) RangerBuilder.Load();
                if (Main.Settings.enableRogueProgression) RogueBuilder.Load();
                if (Main.Settings.enableWizardProgression) WizardBuilder.Load();
            }
        }
    }
}