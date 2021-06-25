using UnityEngine;
using UnityEngine.UI;

namespace VirtualController
{
    public class VirtualControllerManager : MonoBehaviour
    {
        [SerializeField]
        private VirtualControllerSettings _settings;

        private void OnValidate() 
        {
            if(_settings == null)
            {
                SetControllerColor(Color.white);
                return;
            }

            SendColorInfos();    
        }

        private void SendColorInfos()
        {
            SetControllerColor(_settings.m_controllerColor);
            SetButtonDownColor();
            SetButtonUpColor();
            SetSingleAxisColors();
            SetDoubleAxisRawColors();
        }

        private void SetControllerColor(Color color)
        {
            var controllerGraphic = GetComponent<Image>();
            controllerGraphic.color = color;
        }

        private void SetButtonDownColor()
        {
            var buttonDownViewers = GetComponentsInChildren<ButtonDownViewer>();
            foreach (var viewer in buttonDownViewers)
            {
                viewer.ActiveColor = _settings.m_activeControlColor;
            }
        }

        private void SetButtonUpColor()
        {
            var buttonDownViewers = GetComponentsInChildren<ButtonUpViewer>();
            foreach (var viewer in buttonDownViewers)
            {
                viewer.DefaultColor = _settings.m_defaultControlColor;
            }
        }
        private void SetSingleAxisColors()
        {
            var singleAxisViewers = GetComponentsInChildren<SingleAxisViewer>();
            foreach (var viewer in singleAxisViewers)
            {
                viewer.BaseColor = _settings.m_defaultControlColor;
                viewer.MaxValueColor = _settings.m_activeControlColor;
            }
        }

        private void SetDoubleAxisRawColors()
        {
            var padViewers = GetComponentsInChildren<DoubleAxisRawViewer>();
            foreach (var viewer in padViewers)
            {
                viewer.DefaultColor = _settings.m_defaultControlColor;
                viewer.ActiveColor = _settings.m_activeControlColor;
            }
        }
    }
}