using HarmonyLib;
using SolastaLevel20.Models.Classes;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    class GameManagerPatcher
    {
        internal static void FixCastSpellTables()
        {
            var featureDefinitionCastSpellDB = DatabaseRepository.GetDatabase<FeatureDefinitionCastSpell>();

            foreach (var featureDefinitionCastSpell in featureDefinitionCastSpellDB)
            {
                while (featureDefinitionCastSpell.KnownCantrips.Count < MOD_MAX_LEVEL + 1)
                {
                    featureDefinitionCastSpell.KnownCantrips.Add(0);
                }
                while (featureDefinitionCastSpell.KnownSpells.Count < MOD_MAX_LEVEL + 1)
                {
                    featureDefinitionCastSpell.KnownSpells.Add(0);
                }
                while (featureDefinitionCastSpell.ScribedSpells.Count < MOD_MAX_LEVEL + 1)
                {
                    featureDefinitionCastSpell.ScribedSpells.Add(0);
                }
                while (featureDefinitionCastSpell.ReplacedSpells.Count < MOD_MAX_LEVEL + 1)
                {
                    featureDefinitionCastSpell.ReplacedSpells.Add(0);
                }
            }
        }

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
                FixCastSpellTables();
                FixExperienceTable();

                ClericBuilder.Load();
                FighterBuilder.Load();
                PaladinBuilder.Load();
                RangerBuilder.Load();
                RogueBuilder.Load();
                WizardBuilder.Load();
            }
        }
    }
}