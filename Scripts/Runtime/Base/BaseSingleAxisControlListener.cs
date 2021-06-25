using UnityEngine;
using ScriptableObjectArchitecture;

namespace VirtualController
{
    public abstract class BaseSingleAxisControlListener : MonoBehaviour
    {
        #region Exposed
            
        [Header("Config")]
        [SerializeField]
        protected FloatVariable _axisValue;

        #endregion
    }
}
