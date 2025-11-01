using System.Collections.Generic;
using Fsi.DataSystem.Selectors;

namespace Fsi.Characters.Selector
{
    public abstract class CharacterSelectorAttributeDrawer<TChar> : SelectorAttributeDrawer<TChar,string> where TChar : CharacterData
    {
    }
}