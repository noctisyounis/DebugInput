using UnityEngine;
using UnityEngine.UI;

namespace UIRuntime
{
    public class PreserveAspectResize : MonoBehaviour
    {
        #region Public

        [Header("Variables")]

        [SerializeField]
        private RectTransform _targetRectTransform;

        [SerializeField]
        private Image _targetImage;

        #endregion


        #region Unity API

        private void Awake() 
        {
            Initialize();
        }

        private void Update() 
        {
            UpdateRectSize();
        }

        #endregion


        #region Main

        private void Initialize()
        {
            _imageSize = _targetImage.sprite.rect.size;

            _imageRatio = _imageSize.x / _imageSize.y;
        }

        private void UpdateRectSize()
        {
            var rect = _targetRectTransform.rect;
            var rectSize = _targetRectTransform.rect.size;

            var rectRatio = rectSize.x / rectSize.y;
            var adjustedRectSize = rectSize;

            if(Mathf.Approximately(_imageRatio, rectRatio)) return;
            
            if(rectRatio >_imageRatio)
            {
                adjustedRectSize = new Vector2(rectSize.y * _imageRatio, rectSize.y);
            }
            if(rectRatio < _imageRatio)
            {
                adjustedRectSize = new Vector2(rectSize.x, rectSize.x * _imageRatio);
            }

            var sizeDelta = adjustedRectSize - rectSize;

            _targetRectTransform.sizeDelta = sizeDelta;
        }

        #endregion


        #region Private

        private Vector2 _imageSize;
        private float _imageRatio;

        #endregion
    }
}