using UnityEngine;

public class RandomLightColor : MonoBehaviour
{
    [SerializeField] private Light[] _lights;
    private void Awake()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);

        foreach (Light light in _lights)
        {
            light.color = newColor;
        }
    }
}
