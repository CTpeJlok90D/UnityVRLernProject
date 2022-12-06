using UnityEngine;
using UnityEngine.InputSystem;

public class CameraBaseMove : MonoBehaviour
{
    private float _currentAxisValue;
    public void OnMove(InputAction.CallbackContext context)
    {
        _currentAxisValue = context.ReadValue<float>();
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + _currentAxisValue, transform.rotation.eulerAngles.z));
    }
}
