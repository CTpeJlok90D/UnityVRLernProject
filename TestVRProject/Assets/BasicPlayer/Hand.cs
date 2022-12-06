using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Hand : MonoBehaviour
{
    [SerializeField] private UnityEvent _onGrab;
    [SerializeField] private UnityEvent _onDrop;
    private IGrabbleble _lastGrapplebleObjectInTrigger;
    private IGrabbleble _currentGrap;

    public void Grap(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            TakeLastGrappbleObjectInTriger();
        }
        if (context.canceled)
        {
            DropCurrentGrap();
        }
    }

    private void TakeLastGrappbleObjectInTriger()
    {
        if (_lastGrapplebleObjectInTrigger == null)
        {
            return;
        }
        _lastGrapplebleObjectInTrigger.GrapIn(transform);
        _currentGrap = _lastGrapplebleObjectInTrigger;
        _onGrab.Invoke();
    }

    private void DropCurrentGrap()
    {
        if (_currentGrap == null)
        {
            return;
        }
        _currentGrap.Drop();
        _onDrop.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IGrabbleble grapplebleObject))
        {
            _lastGrapplebleObjectInTrigger = grapplebleObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out GrapplebleObject grapplebleObject) && grapplebleObject == _lastGrapplebleObjectInTrigger)
        {
            _lastGrapplebleObjectInTrigger = null;
        }
    }
}
