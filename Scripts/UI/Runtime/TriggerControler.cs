using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;


namespace UIRuntime
{
    public class TriggerControler : MonoBehaviour
    {
        #region Public
        
        [Header("Variables")]

        [SerializeField]
        private FloatVariable _inputIntensity;

        [SerializeField]
        private Image _targetImage;

        [SerializeField]
        private Gradient _pressingColor;

        #endregion


        #region Unity API

        private void Update() 
        {
            UpdateColor();
        }

        #endregion


        #region Main

        private void UpdateColor()
        {
            _targetImage.color = _pressingColor.Evaluate(_inputIntensity.Value);
        }

        #endregion
    }
}