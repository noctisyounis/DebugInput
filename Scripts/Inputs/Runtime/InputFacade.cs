using UnityEngine;
using ScriptableObjectArchitecture;

namespace InputsRuntime
{
    public class InputFacade : MonoBehaviour
    {
        #region Public

        [Header("Variables")]
        
        [SerializeField]
        private KeyCode[] _keys;

        [Header("Events")]
        
        [SerializeField]
        private GameEvent _onKeyDown;

        [SerializeField]
        private GameEvent _onKeyUp;

        #endregion


        #region Unity API
        
        private void Update() 
        {
            foreach(var key in _keys)
            {
                if(Input.GetKeyDown(key))
                {
                    _onKeyDown.Raise();
                }

                if(Input.GetKeyUp(key))
                {
                    _onKeyUp.Raise();
                }
            }
        }

        #endregion
    }
}