using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform t = transform;

        foreach(Transform child in t)
        {
            child.gameObject.SetActive(false);
        }
    }
}
