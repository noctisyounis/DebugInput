using UnityEngine;
using ScriptableObjectArchitecture;

namespace VirtualController
{
    public abstract class BaseButtonControlListener : MonoBehaviour, IGameEventListener
    {
        #region Exposed

        [SerializeField]
        private GameEvent _event;
            
        #endregion


        #region Unity API
            
        private void OnEnable() 
        {
            _event.AddListener(this);    
        }

        private void OnDisable() 
        {
            _event.RemoveListener(this);        
        }

        #endregion

        
        #region Abstract Methods
            
        public abstract void OnEventRaised();

        #endregion
    }
}