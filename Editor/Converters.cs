#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.UIElements;

namespace UIToolkitTools.Editor {
    public static class Converters {
        [InitializeOnLoadMethod]
        public static void RegisterConverters() {
            var boolToDisplayStyle = new ConverterGroup("Bool To DisplayStyle");
            boolToDisplayStyle.AddConverter((ref bool b) => b ? new StyleEnum<DisplayStyle>(DisplayStyle.Flex) : new StyleEnum<DisplayStyle>(DisplayStyle.None));
            ConverterGroups.RegisterConverterGroup(boolToDisplayStyle);
                
            var displayStyleToBool = new ConverterGroup("DisplayStyle To Bool");
            displayStyleToBool.AddConverter((ref StyleEnum<DisplayStyle> displayStyle) => displayStyle == DisplayStyle.Flex);
            ConverterGroups.RegisterConverterGroup(displayStyleToBool);
            
            var intToCurrency = new ConverterGroup("Int To Currency");
            intToCurrency.AddConverter((ref int i) => i.ToString("C"));
            ConverterGroups.RegisterConverterGroup(intToCurrency);
            
            var intToStringWithTwoDigits = new ConverterGroup("Int To String With Two Digits");
            intToStringWithTwoDigits.AddConverter((ref int i) => i.ToString("00"));
            ConverterGroups.RegisterConverterGroup(intToStringWithTwoDigits);
        }
    }
}
#endif