using HarmonyLib;
using static SolastaLevel20.Settings;

namespace SolastaLevel20.Patches
{
    class GameCampaignPartyPatcher
    {
        [HarmonyPatch(typeof(GameCampaignParty), "UpdateLevelCaps")]
        internal static class GameCampaignParty_UpdateLevelCaps_Patch
        {
            internal static bool Prefix(GameCampaignParty __instance)
            {
                int levelCap = MOD_MAX_LEVEL;
                foreach (GameCampaignCharacter characters in __instance.CharactersList)
                {
                    RulesetAttribute attribute1 = characters.RulesetCharacter.GetAttribute("CharacterLevel");
                    attribute1.MaxValue = levelCap > 0 ? levelCap : 13;
                    attribute1.Refresh();
                    RulesetAttribute attribute2 = characters.RulesetCharacter.GetAttribute("Experience");
                    attribute2.MaxValue = HeroDefinitions.MaxHeroExperience(attribute1.MaxValue);
                    attribute2.Refresh();
                }
                return false;
            }
        }
    }
}