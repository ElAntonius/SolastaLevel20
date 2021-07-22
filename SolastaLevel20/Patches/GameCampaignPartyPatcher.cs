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
                foreach (GameCampaignCharacter characters in __instance.CharactersList)
                {
                    RulesetAttribute characterLevelAttribute = characters.RulesetCharacter.GetAttribute("CharacterLevel");
                    characterLevelAttribute.MaxValue = MOD_MAX_LEVEL;
                    characterLevelAttribute.Refresh();
                    RulesetAttribute experienceAttribute = characters.RulesetCharacter.GetAttribute("Experience");
                    experienceAttribute.MaxValue = HeroDefinitions.MaxHeroExperience(characterLevelAttribute.MaxValue);
                    experienceAttribute.Refresh();
                }
                return false;
            }
        }
    }
}