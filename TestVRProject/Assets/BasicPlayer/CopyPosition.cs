using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private bool x = true;
    [SerializeField] private bool y = true;
    [SerializeField] private bool z = true;


    private void Update()
    {
        transform.position = new Vector3(
            x ? _target.position.x : transform.position.x,
            y ? _target.position.y : transform.position.y,
            z ? _target.position.z : transform.position.z
            );
    }
}
