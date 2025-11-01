using System.Collections.Generic;
using Fsi.Characters.Settings;
using UnityEditor;

namespace Fsi.Characters.Selector
{
    [CustomPropertyDrawer(typeof(NpcSelectorAttribute))]
    public class NpcSelectorAttributeDrawer : CharacterSelectorAttributeDrawer<NpcData>
    {
        protected override List<NpcData> GetData() => CharactersSettings.NPCs;
    }
}
