﻿#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.UIElements;

namespace Editor {
    public static class Converters {
        [InitializeOnLoadMethod]
        public static void RegisterConverters() {
            var boolToDisplayStyle = new ConverterGroup("Bool To DisplayStyle");
            boolToDisplayStyle.AddConverter((ref bool b) => b ? new StyleEnum<DisplayStyle>(DisplayStyle.Flex) : new StyleEnum<DisplayStyle>(DisplayStyle.None));
            ConverterGroups.RegisterConverterGroup(boolToDisplayStyle);
                
            var displayStyleToBool = new ConverterGroup("DisplayStyle To Bool");
            displayStyleToBool.AddConverter((ref StyleEnum<DisplayStyle> displayStyle) => displayStyle == DisplayStyle.Flex);
            ConverterGroups.RegisterConverterGroup(displayStyleToBool);
        }
    }
}
#endif