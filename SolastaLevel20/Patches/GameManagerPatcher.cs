using HarmonyLib;
using SolastaLevel20.Models;
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

                BardBuilder.Load();
                ClericBuilder.Load();
                DruidBuilder.Load();
                FighterBuilder.Load();
                PaladinBuilder.Load();
                RangerBuilder.Load();
                RogueBuilder.Load();
                SorcererBuilder.Load();
                TinkererBuilder.Load();
                WizardBuilder.Load();

                ArcaneKnightBuilder.Load();
                ConArtistBuilder.Load();
                MartialSpellBladeBuilder.Load();
                ShadowcasterBuilder.Load();
                SpellShieldBuilder.Load();
                WarShamanBuilder.Load();

                SpellsHelper.FixCastSpellTables();
                SpellsHelper.UpdateSpellLists();
            }
        }
    }
}