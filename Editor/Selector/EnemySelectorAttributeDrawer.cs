using System.Collections.Generic;
using Fsi.Characters.Settings;
using UnityEditor;

namespace Fsi.Characters.Selector
{
    [CustomPropertyDrawer(typeof(EnemySelectorAttribute))]
    public class EnemySelectorAttributeDrawer : CharacterSelectorAttributeDrawer<EnemyData>
    {
        protected override List<EnemyData> GetData() => CharactersSettings.Enemies;
    }
}