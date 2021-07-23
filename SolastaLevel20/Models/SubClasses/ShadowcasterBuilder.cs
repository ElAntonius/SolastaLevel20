using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;

namespace SolastaLevel20.Models.Classes
{
    internal static class ShadowcasterBuilder
    {
        internal static void Load()
        {
            CastSpellShadowcaster.ReplacedSpells.Clear();
            CastSpellShadowcaster.ReplacedSpells.AddRange(Common.OneThirdCasterReplacedSpells);
        }
    }
}