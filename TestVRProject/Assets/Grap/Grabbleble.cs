using UnityEngine;

public interface IGrabbleble
{
    public Rigidbody Rigidbody { get; }
    public void GrapIn(Transform owner);
    public void Drop();
}