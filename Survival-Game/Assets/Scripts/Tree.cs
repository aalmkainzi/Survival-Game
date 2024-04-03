using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public byte hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Log").gameObject.SetActive(false);
    }
}
