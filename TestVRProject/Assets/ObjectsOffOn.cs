using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsOffOn : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObjects;
    public void InvertState()
    {
        foreach(GameObject obj in _gameObjects)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
}
