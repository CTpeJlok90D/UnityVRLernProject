using UnityEngine;

static public class Layer
{
    public static int Default => LayerMask.NameToLayer("Default");
    public static int Grab => LayerMask.NameToLayer("Grab");
}