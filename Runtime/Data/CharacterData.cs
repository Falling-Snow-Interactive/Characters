using Fsi.DataSystem;
using Fsi.General.Sprites.Preview;
using UnityEditor;
using UnityEngine;

namespace Fsi.Characters.Data
{
    [CreateAssetMenu(menuName = Menu + "Data", fileName = "New Character Data")]
    public class CharacterData : ScriptableData<string>
    {
        #region Constants
        
        // Asset Menu
        private new const string Menu = ScriptableData<string>.Menu + "Characters/";

        // Default Assets
        private const string DefaultPortraitPath = "Packages/com.fallingsnowinteractive.characters/Assets/Placeholder/Placeholder_Character_Portrait.png";
            
        #endregion
        
        [Header("Visuals")]

        [SpritePreview]
        [SerializeField]
        private Sprite portrait;
        public Sprite Portrait => portrait;

        private void OnEnable()
        {
            CheckReferences();
        }

        private void Reset()
        {
            CheckReferences();
        }
        
        private void CheckReferences()
        {
            #if UNITY_EDITOR

            ID ??= "npc_";

            if (!portrait)
            {
                Sprite portraitRef = AssetDatabase.LoadAssetAtPath<Sprite>(DefaultPortraitPath);
                portrait = portraitRef;
            }
            #endif
        }
    }
}