using UnityEngine;

public class ColoredSideContainer : MonoBehaviour
{
    [SerializeField]
    private Data.ColoredSide coloredSide;
    public Color Color => coloredSide.SideColor;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        UpdateColor(Color);
    }

    private void UpdateColor(Color color)
    {
        _renderer.material.color = color;
    }
}
