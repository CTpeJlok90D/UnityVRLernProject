using UnityEngine;
using UnityEngine.InputSystem;

public class Button : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _pressedColor = Color.yellow;

    private Color _presetColor;

    public void Press(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            _meshRenderer.material.color = _pressedColor;
            return;
        }
        if (context.canceled) 
        {
            _meshRenderer.material.color = _presetColor;
            return;
        }
    }

    private void Start()
    {
        _presetColor = _meshRenderer.material.color;
    }
}
