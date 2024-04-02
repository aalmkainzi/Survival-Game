using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_input : MonoBehaviour
{
    public inventory inventory;
    public InputActionProperty trigger;
    float held_trigger = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float temp = trigger.action.ReadValue<float>();

        if (held_trigger == 0)
        {
            if (temp != 0)
            {
                inventory.on = !inventory.on;
                inventory.gameObject.SetActive(inventory.on);
                
            }
        }

        held_trigger = temp;
    }
}
