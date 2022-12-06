using UnityEngine;
public static class Vector3Extentions
{
    public static Vector3 RandomVector(Vector3 minValues, Vector3 maxValues)
    {
        Vector3 result = new Vector3();
        for (int i = 0; i < 3; i++)
        {
            result[i] = Random.Range(minValues[i], maxValues[i]);
        }
        return result;
    }
}