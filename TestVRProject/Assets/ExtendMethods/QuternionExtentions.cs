using UnityEngine;

public static class QuternionExtentions
{
    public static Quaternion RandomQuatertnion(Vector3 minValues, Vector3 maxValues)
    {
        Quaternion result = new Quaternion();
        for (int i = 0; i < 3; i++)
        {
            result[i] = Random.Range(minValues[i], maxValues[i]);
        }
        return result;
    }
}