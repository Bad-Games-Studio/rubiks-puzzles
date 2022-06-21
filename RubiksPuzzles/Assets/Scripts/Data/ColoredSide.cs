using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "New Colored Side", menuName = "Scriptable Objects/Colored Side", order = 1)]
    public class ColoredSide : ScriptableObject
    {
        [SerializeField]
        private Color sideColor;

        public Color SideColor => sideColor;
    }
}