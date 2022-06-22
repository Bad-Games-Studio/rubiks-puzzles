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

    private MeshRenderer _meshRenderer;
    private Material _material;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = _meshRenderer.material;
        
        UpdateColor(ActiveColor);
    }

    private void UpdateColor(Color color)
    {
        _material.color = color;
    }
}
