using UnityEngine;

public class ItemHoldier : MonoBehaviour
{
    private Collider _collider;

    private void OnTriggerEnter(Collider other)
    {
        Component inputCollider = other.GetComponent(typeof(IGrabbleble));
        IGrabbleble item = (IGrabbleble)inputCollider;
        if (inputCollider != null && _collider == null && item.Rigidbody.isKinematic == false)
        {
            item.Drop();
            item.GrapIn(transform);
            _collider = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == _collider)
        {
            _collider = null;
        }
    }
}
