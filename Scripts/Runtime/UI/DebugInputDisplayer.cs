using UnityEngine;
using DebugMenu.CustomAttribute.Runtime;

namespace UIRuntime
{
    public class DebugInputDisplayer : MonoBehaviour
    {
        #region Exposed
        [SerializeField]
        private GameObject _target;

        #endregion


        #region Unity API

        private void Awake() 
        {
            _runtimeTarget = _target;    
            _runtimeTarget.SetActive(_isActive);
        }

        #endregion


        #region Main

        [DebugMenu("DebugInput/Toggle")]
        public static void ToggleDebugInput()
        {
            _isActive = !_isActive;

            _runtimeTarget.SetActive(_isActive);
        }

        #endregion


        #region Private

        private static bool _isActive;
        private static GameObject _runtimeTarget;

        #endregion
    }
}