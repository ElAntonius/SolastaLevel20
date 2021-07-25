using HarmonyLib;

namespace SolastaLevel20.Patches
{
    class RulesetSpellRepertoirePatcher
    {
        [HarmonyPatch(typeof(RulesetSpellRepertoire), "MaxSpellLevelOfSpellCastingLevel", MethodType.Getter)]
        internal static class RulesetSpellRepertoire_MaxSpellLevelOfSpellCastingLevel_Getter_Patch
        {
            internal static void Postfix(RulesetSpellRepertoire __instance, ref int __result)
            {
                FeatureDefinitionCastSpell.SlotsByLevelDuplet slotsPerLevel = __instance.SpellCastingFeature.SlotsPerLevels[__instance.SpellCastingLevel - 1];

                int num = slotsPerLevel.Slots.IndexOf(0);
                __result = num;
            }
        }
    }
}