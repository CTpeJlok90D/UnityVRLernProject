using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _maxSpeed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _mainCamera;

    private Vector2 _currentIntput;

    public void Move(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            _currentIntput = Vector2.zero;
            return;
        }
        _currentIntput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        if (_currentIntput != Vector2.zero)
        {
            Quaternion headDirection = Quaternion.Euler(0, _mainCamera.eulerAngles.y, 0);
            _rigidbody.velocity = headDirection * new Vector3(_currentIntput.x, 0, _currentIntput.y) * _maxSpeed;
        }
    }
}
