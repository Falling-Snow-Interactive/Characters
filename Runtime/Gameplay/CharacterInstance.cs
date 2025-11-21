using System;
using Fsi.Characters.Data;
using Fsi.Characters.Data.Selector;
using UnityEngine;

namespace Fsi.Characters.Gameplay
{
    public class CharacterInstance : MonoBehaviour
    {
        #region Events
        
        public static event Action<CharacterInstance> Spawned;
        public static event Action<CharacterInstance> Despawned;
        
        #endregion

        #region Inspector Variables
        
        [SerializeField]
        private int instanceID = 0;
        
        [CharacterSelector]
        [SerializeField]
        private CharacterData data;
        public CharacterData Data => data;
        
        #endregion
        
        #region Public Properties
        
        public string ID => data.ID + "_" + instanceID;
        
        #endregion

        private void Start()
        {
            Setup();
            
            Spawned?.Invoke(this);
        }

        private void OnDestroy()
        {
            Despawned?.Invoke(this);
        }

        protected virtual void Setup()
        {
            // Any setup gets done here...
        }
    }
}