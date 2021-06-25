using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public class SingleAxisViewer : BaseSingleAxisControlListener
    {
        #region Exposed

        [Header("Viewer")]
        [SerializeField]
        private Image _controlGraphic;

        #endregion


        #region Setters
            
        public Color BaseColor 
        { 
            set{
                _baseColor = value;
                _controlGraphic.color = _baseColor;
            }
        }
        public Color MaxValueColor { set => _maxValueColor = value; }

        #endregion


        #region Unity API

        private void Update() 
        {
            _controlGraphic.color = Color.Lerp(_baseColor, _maxValueColor, _axisValue);
        }
            
        #endregion


        #region Private Fields

        private Color _baseColor = Color.white;
        private Color _maxValueColor = Color.grey;
            
        #endregion
    }
}