using UnityEngine;

public class PhysicalHand : MonoBehaviour
{
    [SerializeField] private Transform _controller;
    [SerializeField] private Rigidbody _rigidbody;

    private void Awake()
    {
        transform.position = _controller.position;
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = (_controller.position - transform.position) / Time.fixedDeltaTime;
        
        Quaternion _controllerQuanternion = _controller.rotation * Quaternion.Inverse(transform.rotation);
        _controllerQuanternion.ToAngleAxis(out float angle, out Vector3 axis);
        Vector3 rotationInDegree = angle * axis;

        _rigidbody.angularVelocity = rotationInDegree / Time.fixedDeltaTime;
    }
}
