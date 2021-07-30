﻿using System;
using System.Collections.Generic;
using HarmonyLib;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    // allows custom dungeons to be set for parties up to level 20
    class UserLocationSettingsModalPatcher
    {
        [HarmonyPatch(typeof(UserLocationSettingsModal), "OnMinLevelEndEdit")]
        public class UserLocationSettingsModal_OnMinLevelEndEdit_Patch
        {
            internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var code = new List<CodeInstruction>(instructions);
                var opcodes = code.FindAll(x => x.opcode.Name == "ldc.i4.s" && Convert.ToInt32(x.operand) == GAME_MAX_LEVEL);
                foreach (var opcode in opcodes)
                    opcode.operand = MOD_MAX_LEVEL;

                return code;
            }
        }

        [HarmonyPatch(typeof(UserLocationSettingsModal), "OnMaxLevelEndEdit")]
        public class UserLocationSettingsModal_OnMaxLevelEndEdit_Patch
        {
            internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var code = new List<CodeInstruction>(instructions);
                var opcodes = code.FindAll(x => x.opcode.Name == "ldc.i4.s" && Convert.ToInt32(x.operand) == GAME_MAX_LEVEL);
                foreach (var opcode in opcodes)
                    opcode.operand = MOD_MAX_LEVEL;

                return code;
            }
        }
    }
}