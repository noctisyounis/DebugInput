using UnityEngine;
using ScriptableObjectArchitecture;

namespace VirtualController
{
    public class BaseButtonControlDispatcher : MonoBehaviour
    {
        #region Exposed

        [Header("Config")]
        [SerializeField]
        private KeyCode _key;

        [Header("Events")]
        [SerializeField]
        private GameEvent OnKeyDown;
        [SerializeField]
        private GameEvent OnKeyUp;
        
        #endregion


        #region Unity API
            
        private void Update() 
        {
            if(Input.GetKeyDown(_key))
            {
                OnKeyDown.Raise();
            }
            
            else if(Input.GetKeyUp(_key))
            {
                OnKeyUp.Raise();
            }
        }

        #endregion
    }
}