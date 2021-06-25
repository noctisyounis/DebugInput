using UnityEngine;
using ScriptableObjectArchitecture;

namespace InputsRuntime
{
    public class AxisFacade : MonoBehaviour
    {
        #region Public

        [Header("Variables")]

        [SerializeField]
        private string _axisName;

        [SerializeField]
        private FloatVariable _axis;

        #endregion


        #region Unity API

        private void Update() 
        {
            _axis.Value = Input.GetAxis(_axisName);
        }

        #endregion
    }
}