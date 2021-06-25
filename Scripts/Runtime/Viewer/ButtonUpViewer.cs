using UnityEngine;

namespace VirtualController
{
    public class ButtonUpViewer : BaseButtonViewer
    {
        #region Setters

        public Color DefaultColor 
        {
             set{
                 _defaultColor = value;
                 _controlGraphic.color = _defaultColor; 
             }
        }
            
        #endregion


        #region Main
            
        public override void OnEventRaised()
        {
            _controlGraphic.color = _defaultColor;
        }

        #endregion


        #region Private Fields
            
        private Color _defaultColor;

        #endregion
    }
}