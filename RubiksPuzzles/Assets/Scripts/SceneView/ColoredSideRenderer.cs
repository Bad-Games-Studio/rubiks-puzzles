using UnityEngine;

namespace SceneView
{
    [ExecuteAlways]
    public class ColoredSideRenderer : MonoBehaviour
    {
#if UNITY_EDITOR
        private Renderer _renderer;
        private ColoredSideContainer _side;
    
        private Material _customMaterial;
    
        private void Awake()
        {
            // To avoid memory leaks in editor when altering `_renderer.material`.
            _renderer = GetComponent<Renderer>();
            _customMaterial = new Material(_renderer.sharedMaterial);
            _renderer.sharedMaterial = _customMaterial;
        }

        private void OnEnable()
        {
            _side = GetComponent<ColoredSideContainer>();
            SetColor();
        }

        private void Update()
        {
            if (Application.isPlaying)
            {
                return;
            }
            SetColor();
        }

        private void SetColor()
        {
            _customMaterial.color = _side.IsActive ? _side.ActiveColor : _side.InactiveColor;
        }
#endif
    }
}