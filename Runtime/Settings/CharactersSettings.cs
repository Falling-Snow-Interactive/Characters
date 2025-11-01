using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Fsi.Characters.Settings
{
    public class CharactersSettings : ScriptableObject
    {
        private const string ResourcePath = "Settings/Characters Settings";
        private const string FullPath = "Assets/Resources/" + ResourcePath + ".asset";

        private static CharactersSettings settings;
        public static CharactersSettings Settings => settings ??= GetOrCreateSettings();

        [Header("Library")]

        [SerializeField]
        private List<NpcData> npcs = new(); // ReSharper disable once InconsistentNaming
        public static List<NpcData> NPCs => Settings.npcs;

        [SerializeField]
        private List<EnemyData> enemies = new();
        public static List<EnemyData> Enemies => Settings.enemies;

        #region Settings

        private static CharactersSettings GetOrCreateSettings()
        {
            CharactersSettings set = Resources.Load<CharactersSettings>(ResourcePath);

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

                set = CreateInstance<CharactersSettings>();
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