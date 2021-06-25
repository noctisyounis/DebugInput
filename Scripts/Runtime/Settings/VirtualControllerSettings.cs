using UnityEngine;

namespace VirtualController
{
    [CreateAssetMenu(fileName = "VirtualControllerSettings", menuName = "VirtualController/VirtualControllerSettings", order = 0)]
    public class VirtualControllerSettings : ScriptableObject
    {
        public Color m_controllerColor = Color.white;
        public Color m_defaultControlColor = Color.white;
        public Color m_activeControlColor = Color.gray;
    }
}