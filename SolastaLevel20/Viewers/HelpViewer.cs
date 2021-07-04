using UnityModManagerNet;
using ModKit;

namespace SolastaLevel20.Viewers
{
    public class HelpViewer : IMenuSelectablePage
    {
        public string Name => "Help";

        public int Priority => 0;

        private static readonly string PLANNED = " [" + "planned".cyan() + "] ";

        private const float DEFAULT_WIDTH = 250;

        private static void DisplayCleric(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();
                UI.Label("Cleric".green());
                UI.Label("11 - Turn Undead");
                UI.Label("12 - Ability score or feat");
                UI.Label("14 - Turn Undead");
                UI.Label("16 - Ability score or feat");
                UI.Label("17 - Turn Undead");
                UI.Label("18 - Channel Divinity");
                UI.Label("19 - Ability score or feat");
                UI.Label("20 - Divine Intervention Improvement" + PLANNED);
            }
        }

        private static void DisplayFighter(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();
                UI.Label("Fighter".green());
                UI.Label("11 - Extra Attack");
                UI.Label("12 - Ability score or feat");
                UI.Label("13 - Indomitable");
                UI.Label("14 - Ability score or feat");
                UI.Label("16 - Ability score or feat");
                UI.Label("17 - Action Surge / Indomitable");
                UI.Label("19 - Ability score or feat");
                UI.Label("20 - Extra Attack");
            }
        }

        private static void DisplayPaladin(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();

                UI.Label("Paladin".green());
                UI.Label("12 - Ability score or feat");
                UI.Label("14 - Cleansing Touch" + PLANNED);
                UI.Label("16 - Ability score or feat");
                UI.Label("18 - Aura of Courage / Aura of Protection");
                UI.Label("19 - Ability score or feat");
            }
        }

        private static void DisplayRanger(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();
                UI.Label("Ranger".green());
                UI.Label("12 - Ability score or feat");
                UI.Label("14 - Favored Enemy");
                UI.Label("16 - Ability score or feat");
                UI.Label("18 - Feral Senses" + PLANNED);
                UI.Label("19 - Ability score or feat");
                UI.Label("20 - Foe Slayer" + PLANNED);
            }
        }

        private static void DisplayRogue(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();
                UI.Label("Rogue".green());
                UI.Label("12 - Ability score or feat");
                UI.Label("14 - Blind Sense");
                UI.Label("15 - Slippery Mind");
                UI.Label("16 - Ability score or feat");
                UI.Label("18 - Elusive" + PLANNED);
                UI.Label("19 - Ability score or feat");
                UI.Label("20 - Stroke of Luck" + PLANNED);
            }
        }

        private static void DisplayWizard(float width = DEFAULT_WIDTH)
        {
            using (UI.VerticalScope(UI.Width(width)))
            {
                UI.Div();
                UI.Label("Wizard".green());
                UI.Label("12 - Ability score or feat");
                UI.Label("14 - Over Channel" + PLANNED);
                UI.Label("16 - Ability score or feat");
                UI.Label("18 - Spell Mastery" + PLANNED);
                UI.Label("19 - Ability score or feat");
                UI.Label("20 -Signature Spells" + PLANNED);
            }
        }

        private static void DisplayHelp()
        {
            UI.Label("Welcome to Level 20".yellow().bold(), UI.AutoWidth());
            UI.Div();
            UI.Label("Features:".yellow());
            UI.Label(". unlocks game progression to level 20");
            UI.Label(". adds missing SRD features to game official classes as below");
            UI.Label(". supports Barbarian, Bard, Monk, Tinkerer and many other unofficial modded classes and subclasses");
            UI.Label("Current Limitations:".yellow());
            UI.Label(". no additional features added to subclasses progression");
            UI.Label(". some class progression features still" + PLANNED + "as below");
            UI.Div();

            using (UI.HorizontalScope())
            {
                DisplayCleric(300);
                DisplayFighter();
                DisplayPaladin();
                DisplayRanger();
                DisplayRogue();
                DisplayWizard();
            }
        }

        public void OnGUI(UnityModManager.ModEntry modEntry)
        {
            if (Main.Mod == null) return;

            DisplayHelp();
        }
    }
}