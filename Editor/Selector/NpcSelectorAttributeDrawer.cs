using System.Collections.Generic;
using Fsi.Characters.Data;
using Fsi.Characters.Settings;
using UnityEditor;

namespace Fsi.Characters.Selector
{
    [CustomPropertyDrawer(typeof(NPCSelectorAttribute))]
    public class NpcSelectorAttributeDrawer : CharacterSelectorAttributeDrawer<NPCData>
    {
        protected override List<NPCData> GetData() => CharactersSettings.NPCs;
    }
}
