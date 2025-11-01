using Fsi.DataSystem;
using UnityEngine;

namespace Fsi.Characters
{
    [CreateAssetMenu(menuName = "Fsi/Character/Data", fileName = "New Character Data")]
    public abstract class CharacterData : ScriptableData<string>
    {
    }
}
