using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using SolastaModApi.Extensions;

namespace SolastaLevel20.Models.Classes
{
    internal static class MartialSpellBladeBuilder
    {
        internal static void Load()
        {
            CastSpellMartialSpellBlade.SetSpellCastingLevel(-1);

            CastSpellMartialSpellBlade.ReplacedSpells.Clear();
            CastSpellMartialSpellBlade.ReplacedSpells.AddRange(Common.OneThirdCasterReplacedSpells);

            CastSpellMartialSpellBlade.SlotsPerLevels.Clear();
            CastSpellMartialSpellBlade.SlotsPerLevels.AddRange(Common.OneThirdCastingSlots);
        }
    }
}