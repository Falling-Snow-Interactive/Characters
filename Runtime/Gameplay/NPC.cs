using Fsi.Characters.Data;
using UnityEngine;

namespace Fsi.Characters.Gameplay
{
    /// <summary>
    /// This goes on the in scene NPCs. Connects that NPC instance to the NPC data.
    /// </summary>
    public class NPC : Character
    {
        public override CharacterData Data => npcData;
        
        // [NPCSelector]
        [SerializeField]
        private NPCData npcData;
        public NPCData NPCData => npcData;
    }
}