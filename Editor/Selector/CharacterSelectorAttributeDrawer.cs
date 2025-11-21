using System.Collections.Generic;
using Fsi.Characters.Data;
using Fsi.Characters.Data.Selector;
using Fsi.Characters.Settings;
using Fsi.DataSystem.Selectors;
using UnityEditor;

namespace Fsi.Characters.Selector
{
    [CustomPropertyDrawer(typeof(CharacterSelectorAttribute))]
    public class CharacterSelectorAttributeDrawer : SelectorAttributeDrawer<CharacterData,string> 
    {
        protected override List<CharacterData> GetEntries() => CharacterSettings.Characters.Entries;
    }
}