using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_input : MonoBehaviour
{
    public inventory inventory;
    public InputActionProperty trigger;
    public InputActionProperty grip;
    public GameObject rightray;
    public GameObject righthand;
    public Item righthand_item;
    // Start is called before the first frame update
    void Start()
    {
        rightray.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bool grip_pressed    = grip.action.ReadValue<float>() != 0;
        bool trigger_pressed = trigger.action.ReadValue<float>() != 0;
        if (inventory.on && grip_pressed)
        {
            inventory.on = false;
            inventory.gameObject.SetActive(false);
            righthand.SetActive(true);
            rightray.SetActive(false);

            inventory.held_item = righthand_item;
        }
        else if(!inventory.on && trigger_pressed)
        {
            inventory.on = true;
            inventory.gameObject.SetActive(true);
            righthand.SetActive(false);
            rightray.SetActive(true);

            switch (inventory.held_item)
            {
                case Axe: Instantiate(GameObject.Find("Axe_prefab"), righthand.transform.position, Quaternion.identity); break;
            }
        }
    }
}
