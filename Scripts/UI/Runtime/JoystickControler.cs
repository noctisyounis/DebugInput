using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

namespace UIRuntime
{
    public class JoystickControler : MonoBehaviour
    {
        #region Public

        [Header("Variables")]
        
        [SerializeField]
        private float _offsetCoefficient = 1f;

        [SerializeField]
        private FloatVariable _verticalAxis;
        
        [SerializeField]
        private FloatVariable _horizontalAxis;

        [SerializeField]
        private RectTransform _targetRectTransform;

        #endregion


        #region Unity API
        
        private void Update() 
        {
            UpdatePosition();
        }

        #endregion


        #region Main

        private void UpdatePosition()
        {
            var offsetDirection = new Vector2(_horizontalAxis.Value, _verticalAxis.Value).normalized;
            var offset = _targetRectTransform.rect.size.magnitude / 4 * _offsetCoefficient;

            _targetRectTransform.anchoredPosition = offsetDirection * offset;
        }

        #endregion
    }
}