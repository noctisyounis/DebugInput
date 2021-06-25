using UnityEngine;

namespace VirtualController
{
    public class ButtonDownViewer : BaseButtonViewer
    {
        #region Setters

        public Color ActiveColor { set => _activeColor = value; }
            
        #endregion

        #region Main
            
        public override void OnEventRaised()
        {
            _controlGraphic.color = _activeColor;
        }

        #endregion


        #region Private Fields

        private Color _activeColor;
            
        #endregion
    }
}