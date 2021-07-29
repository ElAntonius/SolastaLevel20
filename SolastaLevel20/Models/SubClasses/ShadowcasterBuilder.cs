using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using SolastaModApi.Extensions;

namespace SolastaLevel20.Models.Classes
{
    internal static class ShadowcasterBuilder
    {
        internal static void Load()
        {
            CastSpellShadowcaster.SetSpellCastingLevel(-1);

            CastSpellShadowcaster.ReplacedSpells.Clear();
            CastSpellShadowcaster.ReplacedSpells.AddRange(Common.OneThirdCasterReplacedSpells);

            CastSpellShadowcaster.SlotsPerLevels.Clear();
            CastSpellShadowcaster.SlotsPerLevels.AddRange(Common.OneThirdCastingSlots);
        }
    }
}