using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace SolastaLevel20.Patches
{
    // unhides features for levels above 10
    class HigherLevelFeaturesModalPatcher
    {
        [HarmonyPatch(typeof(HigherLevelFeaturesModal), "Bind")]
        internal static class HigherLevelFeaturesModal_Bind_Patch
        {
            internal static bool Prefix(
                HigherLevelFeaturesModal __instance, 
                List<FeatureUnlockByLevel> featureUnlocks, 
                int achievementLevel,
                GameObject ___featureItemPrefab,
                RectTransform ___featuresTable,
                List<FeatureUnlockByLevel> ___visibleFeatures)
            {
                if (__instance == null)
                    return true;

                ___visibleFeatures.Clear();
                foreach (FeatureUnlockByLevel featureUnlock in featureUnlocks)
                {
                    //if (!featureUnlock.FeatureDefinition.GuiPresentation.Hidden && featureUnlock.Level > achievementLevel)
                    if (featureUnlock.Level > achievementLevel)
                        ___visibleFeatures.Add(featureUnlock);
                }
                while (___featuresTable.childCount < ___visibleFeatures.Count)
                    Gui.GetPrefabFromPool(___featureItemPrefab, (Transform)___featuresTable);
                int num = -1;
                for (int index = 0; index < ___featuresTable.childCount; ++index)
                {
                    Transform child = ___featuresTable.GetChild(index);
                    HigherFeatureItem component = child.GetComponent<HigherFeatureItem>();
                    if (index < ___visibleFeatures.Count)
                    {
                        child.gameObject.SetActive(true);
                        component.name = ___visibleFeatures[index].FeatureDefinition.Name;
                        if (num == ___visibleFeatures[index].Level)
                        {
                            component.Bind(___visibleFeatures[index].FeatureDefinition, -1, false);
                        }
                        else
                        {
                            component.Bind(___visibleFeatures[index].FeatureDefinition, ___visibleFeatures[index].Level, num != -1);
                            num = ___visibleFeatures[index].Level;
                        }
                    }
                    else
                    {
                        component.Unbind();
                        child.gameObject.SetActive(false);
                    }
                }
                LayoutRebuilder.ForceRebuildLayoutImmediate(___featuresTable);
                return false;
            }
        }
    }
}