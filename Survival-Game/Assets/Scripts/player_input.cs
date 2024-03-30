using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_input : MonoBehaviour
{
    public inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            inventory.on = !inventory.on;
            inventory.gameObject.SetActive(inventory.on);
        }
    }
}
