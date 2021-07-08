using System;
using System.Collections.Generic;
using HarmonyLib;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    class CharactersPanelPatcher
    {
        [HarmonyPatch(typeof(CharactersPanel), "Refresh")]
        internal static class CharactersPanel_Refresh_Patch
        {
            internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var code = new List<CodeInstruction>(instructions);
                code.Find(x => x.opcode.Name == "ldc.i4.s" && Convert.ToInt32(x.operand) == 10).operand = MOD_MAX_LEVEL; // using a hard-coded 10 here until TA changes to 13
                return code;
            }
        }
    }
}