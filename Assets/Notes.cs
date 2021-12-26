using UnityEngine;
using System;

public class Notes : MonoBehaviour
{
    public static event Action<string> toneName = delegate { };

    private void OnMouseDown () {
        toneName (name);
    }
}
