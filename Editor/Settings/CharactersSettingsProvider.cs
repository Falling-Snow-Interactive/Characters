using Fsi.Ui.Spacers;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Fsi.Characters.Settings
{
    public static class CharactersSettingsProvider
    {
        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            SettingsProvider provider = new("Fsi/Characters", SettingsScope.Project)
            {
                label = "Characters",
                activateHandler = OnActivate,
            };
        
            return provider;
        }

        private static void OnActivate(string searchContext, VisualElement root)
        {
            root.style.marginTop = 5;
            root.style.marginRight = 5;
            root.style.marginLeft = 5;
            root.style.marginBottom = 5;
    
            SerializedObject settingsProp = CharactersSettings.GetSerializedSettings();
        
            Label title = new("Characters Settings");
            root.Add(title);
        
            root.Add(new Spacer());
        
            root.Add(new InspectorElement(settingsProp));
        
            root.Bind(settingsProp);
        }
    }
}