using UnityEngine;
using ScriptableObjectArchitecture;

namespace VirtualController
{
    public abstract class BaseDoubleAxisControlListener : MonoBehaviour
    {
        #region Exposed
            
        [Header("Config")]
        [SerializeField]
        protected FloatVariable _xAxisValue;
        [SerializeField]
        protected FloatVariable _yAxisValue;

        #endregion
    }
}
