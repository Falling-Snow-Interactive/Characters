using Fsi.Characters.Data;
using Fsi.DataSystem.Libraries;
using UnityEditor;
using UnityEngine;

namespace Fsi.Characters.Settings
{
    public class CharacterSettings : ScriptableObject
    {
        private const string ResourcePath = "Settings/Characters Settings";
        private const string FullPath = "Assets/Resources/" + ResourcePath + ".asset";

        private static CharacterSettings settings;
        public static CharacterSettings Settings => settings ??= GetOrCreateSettings();

        [Header("Libraries")]

        [SerializeField]
        private Library<CharacterData,string> characters = new(); // ReSharper disable once InconsistentNaming
        public static Library<CharacterData,string> Characters => Settings.characters;

        #region Settings

        private static CharacterSettings GetOrCreateSettings()
        {
            CharacterSettings set = Resources.Load<CharacterSettings>(ResourcePath);

            #if UNITY_EDITOR
            if (!set)
            {
                if (!AssetDatabase.IsValidFolder("Assets/Resources"))
                {
                    AssetDatabase.CreateFolder("Assets", "Resources");
                }

                if (!AssetDatabase.IsValidFolder("Assets/Resources/Settings"))
                {
                    AssetDatabase.CreateFolder("Assets/Resources", "Settings");
                }

                set = CreateInstance<CharacterSettings>();
                AssetDatabase.CreateAsset(set, FullPath);
                AssetDatabase.SaveAssets();
            }
            #endif

            return set;
        }

        #if UNITY_EDITOR
        public static SerializedObject GetSerializedSettings()
        {
            return new SerializedObject(GetOrCreateSettings());
        }
        #endif

        #endregion
    }
}