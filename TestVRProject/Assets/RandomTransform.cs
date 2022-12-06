using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTransform : MonoBehaviour
{
    [Header("Position")]
    [SerializeField] private bool _randomPosition = false;
    [SerializeField] private Vector3 _minPosition = Vector2.zero;
    [SerializeField] private Vector3 _maxPosition = Vector2.one;
    [Header("Rotation")]
    [SerializeField] private bool _randomRotation = false;
    [SerializeField] private Vector3 _minRotation = Vector2.zero;
    [SerializeField] private Vector3 _maxRotation = Vector2.one;
    [Header("Scale")]
    [SerializeField] private bool _randomScale = false;
    [SerializeField] private Vector3 _minScale = Vector2.zero;
    [SerializeField] private Vector3 _maxScale = Vector2.one;
    private void Start()
    {
        if (_randomPosition)
        {
            transform.position = Vector3Extentions.RandomVector(_minPosition, _maxPosition);
        }
        if (_randomRotation)
        {
            transform.rotation = QuternionExtentions.RandomQuatertnion(_minRotation, _maxRotation);
        }
        if (_randomScale)
        {
            transform.localScale = Vector3Extentions.RandomVector(_minScale, _maxScale);
        }
        Destroy(this);
    }
}
