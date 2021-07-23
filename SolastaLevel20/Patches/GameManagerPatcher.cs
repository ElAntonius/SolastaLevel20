using HarmonyLib;
using SolastaLevel20.Models.Classes;

namespace SolastaLevel20.Patches
{
    class GameManagerPatcher
    {
        [HarmonyPatch(typeof(GameManager), "BindPostDatabase")]
        internal static class GameManager_BindPostDatabase_Patch
        {
            internal static void Postfix()
            {
                ElfHighBuilder.Load();

                ClericBuilder.Load();
                FighterBuilder.Load();
                PaladinBuilder.Load();
                RangerBuilder.Load();
                RogueBuilder.Load();
                WizardBuilder.Load();

                MartialSpellBladeBuilder.Load();
                MartialSpellBladeBuilder.Load();
            }
        }
    }
}