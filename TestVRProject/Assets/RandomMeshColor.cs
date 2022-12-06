using UnityEngine;

public class RandomMeshColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer[] _meshRenderers;
    void Awake()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        foreach (MeshRenderer meshRenderer in _meshRenderers)
        {
            meshRenderer.material.color = newColor;
        }
        Destroy(this);
    }
}
