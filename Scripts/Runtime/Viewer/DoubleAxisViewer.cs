using UnityEngine;

namespace VirtualController
{
    public class DoubleAxisViewer : BaseDoubleAxisControlListener
    {
        #region Exposed

        [Header("Viewer")]
        [SerializeField]
        private RectTransform _referenceTransform;
        [SerializeField]
        private RectTransform _graphicTransform;
        [SerializeField, Range(0, 2)]
        private float _maxDisplacement;
            
        #endregion


        #region Unity API

        protected virtual void Update() 
        {
            var moveVector = new Vector3(_xAxisValue, _yAxisValue, 0) * _maxDisplacement * _graphicTransform.rect.size.magnitude;
            _graphicTransform.position = _referenceTransform.position + moveVector;
        }
        
        #endregion
    }
}