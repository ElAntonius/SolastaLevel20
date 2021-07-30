using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using SolastaModApi.Extensions;

namespace SolastaLevel20.Models.Classes
{
    internal static class MartialSpellBladeBuilder
    {
        internal static void Load()
        {
            CastSpellMartialSpellBlade.SetSpellCastingLevel(4);

            CastSpellMartialSpellBlade.ReplacedSpells.Clear();
            CastSpellMartialSpellBlade.ReplacedSpells.AddRange(SpellsHelper.OneThirdCasterReplacedSpells);

            CastSpellMartialSpellBlade.SlotsPerLevels.Clear();
            CastSpellMartialSpellBlade.SlotsPerLevels.AddRange(SpellsHelper.OneThirdCastingSlots);
        }
    }
}