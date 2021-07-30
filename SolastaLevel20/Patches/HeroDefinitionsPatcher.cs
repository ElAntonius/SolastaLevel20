using HarmonyLib;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    // caps level up to 20 max
    class HeroDefinitionsPatcher
    {
        [HarmonyPatch(typeof(HeroDefinitions), "MaxHeroExperience")]
        internal static class HeroDefinitions_MaxHeroExperience_Patch
        {
            internal static bool Prefix(ref int __result)
            {
                __result = MAX_CHARACTER_EXPERIENCE;
                return false;
            }
        }
    }
}