using System;
using System.Collections.Generic;
using Fsi.Gameplay;
using Fsi.General;

namespace Fsi.Characters.Gameplay
{
    public class CharacterManager : MbSingleton<CharacterManager>
    {
        public static event Action<CharacterManager> Changed;
        
        public Dictionary<string, CharacterInstance> Characters { get; } = new();

        private void OnEnable()
        {
            CharacterInstance.Spawned += OnCharacterSpawn;
            CharacterInstance.Despawned += OnCharacterDespawn;
        }

        private void OnDisable()
        {
            CharacterInstance.Spawned -= OnCharacterSpawn;
            CharacterInstance.Despawned -= OnCharacterDespawn;
        }

        private void OnCharacterSpawn(CharacterInstance character)
        {
            if (Characters.TryAdd(character.ID, character))
            {
                Changed?.Invoke(this);
            }
        }

        private void OnCharacterDespawn(CharacterInstance character)
        {
            if (Characters.Remove(character.ID))
            {
                Changed?.Invoke(this);
            }
        }
    }
}