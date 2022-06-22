using UnityEngine;

public class ColoredSideContainer : MonoBehaviour
{
    [SerializeField] private Data.ColoredSide activeSide;
    [SerializeField] private Data.ColoredSide inactiveSide;

    [SerializeField] private bool isActive;

    public Color ActiveColor => activeSide.SideColor;
    public Color InactiveColor => inactiveSide.SideColor;
    
    public bool IsActive
    {
        get => isActive;
        set => isActive = value;
    }

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        UpdateColor(ActiveColor);
    }

    private void UpdateColor(Color color)
    {
        _renderer.material.color = color;
    }
}
