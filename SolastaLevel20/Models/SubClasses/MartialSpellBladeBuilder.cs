using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;

namespace SolastaLevel20.Models.Classes
{
    internal static class MartialSpellBladeBuilder
    {
        internal static void Load()
        {
            CastSpellMartialSpellBlade.ReplacedSpells.Clear();
            CastSpellMartialSpellBlade.ReplacedSpells.AddRange(Common.OneThirdCasterReplacedSpells);
        }
    }
}