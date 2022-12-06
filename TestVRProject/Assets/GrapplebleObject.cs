using UnityEngine;

class GrapplebleObject : MonoBehaviour, IGrabbleble
{
    [SerializeField] private GameObject _mainParent;
    [SerializeField] private Rigidbody _rigidbody;

    private Transform _owner;

    public GameObject MainParent => _mainParent;

    public Rigidbody Rigidbody => _rigidbody;

    public void Drop()
    {
        _owner = null;
        SetLayer(Layer.Default);
        _rigidbody.isKinematic = false;
        _rigidbody.useGravity = true;
    }

    public void GrapIn(Transform owner)
    {
        _owner = owner;
        SetLayer(Layer.Grab);
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
    }

    private void FixedUpdate()
    {
        if (_owner != null)
        {
            _rigidbody.MovePosition(Vector3.MoveTowards(_rigidbody.position, _owner.transform.position,0.1f));
            _rigidbody.MoveRotation(_owner.transform.rotation);
        }
    }
    private void Start()
    {
        if(_rigidbody == null)
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
    }

    private void SetLayer(int layer)
    {
        _mainParent.layer = layer;
        foreach(Transform child in _mainParent.transform)
        {
            child.gameObject.layer = layer;
        }
    }
}