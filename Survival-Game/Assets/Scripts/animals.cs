using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animals : MonoBehaviour
{
    public float aHealth;
    public float aHealthMax = 50;
    // Start is called before the first frame update
    void Start()
    {
        aHealth = aHealthMax;
        gameObject.transform.Find("Loot").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
