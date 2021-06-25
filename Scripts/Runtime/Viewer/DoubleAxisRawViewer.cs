using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public class DoubleAxisRawViewer : DoubleAxisViewer
    {
        #region Exposed
            
        [Header("Double axis raw viewer")]
        [SerializeField]
        private Image _controlGraphic;

        #endregion


        #region Setters

        public Color DefaultColor 
        {
             set{
                 _defaultColor = value;
                 _controlGraphic.color = _defaultColor; 
             }
        }

        public Color ActiveColor { set => _activeColor = value; }
            
        #endregion


        #region Unity API

        private void Awake()
        {
            _controlGraphic.color = _defaultColor;    
        }
        
        protected override void Update() 
        {
            var isInactive = Mathf.Approximately(_xAxisValue, 0) && Mathf.Approximately(_yAxisValue, 0);
            _controlGraphic.color = isInactive ? _defaultColor : _activeColor;

            base.Update();            
        }

        #endregion


        #region Privqte Fields

        private Color _defaultColor = Color.white;
        private Color _activeColor = Color.grey;
            
        #endregion
    }
}