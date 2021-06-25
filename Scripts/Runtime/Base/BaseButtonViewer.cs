using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public abstract class BaseButtonViewer : BaseButtonControlListener
    {
        #region Exposed
            
        [Header("Config")]
        [SerializeField]
        protected Image _controlGraphic;

        #endregion
    }
}