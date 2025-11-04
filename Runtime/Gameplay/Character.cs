using Fsi.Characters.Data;
using UnityEngine;

namespace Fsi.Characters.Gameplay
{
    public abstract class Character : MonoBehaviour
    {
        public abstract CharacterData Data { get; }
    }
}