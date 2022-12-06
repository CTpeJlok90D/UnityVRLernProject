using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Destroeble : MonoBehaviour
{
    [SerializeField] private float _health = 10; 
    [SerializeField] private GameObject _destroyedObject;
    [SerializeField] private float _minSpeedTodamage;
    [SerializeField] private Rigidbody _rigidbody;

    public bool MustBroke(Rigidbody rigidbody)
    {
        Vector3 otherVelocity = rigidbody.velocity;
        Vector3 velocity = _rigidbody.velocity;
        return otherVelocity.x + velocity.x > _minSpeedTodamage || otherVelocity.y + velocity.y > _minSpeedTodamage || otherVelocity.z + velocity.z > _minSpeedTodamage;
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (TryGetComponent(out Rigidbody rigidbody) && MustBroke(rigidbody))
        {
            _health -= rigidbody.velocity.magnitude;
            if (_health <= 0)
            {
                Broke();
            }
        }
    }

    private void Broke()
    {
        Instantiate(_destroyedObject, transform.position, transform.rotation).transform.localScale = transform.localScale;
        Destroy(gameObject);
    }
}
