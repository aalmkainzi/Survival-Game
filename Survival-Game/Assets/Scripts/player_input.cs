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
    public SkinnedMeshRenderer righthand_rend;
    public Item righthand_item;
    public GameObject prefabs;

    bool ignore_grip = false;
    bool invon_nextframe = false;
    Item icopy = null;
    // Start is called before the first frame update
    void Start()
    {
        rightray.SetActive(false);
        prefabs = GameObject.Find("Prefabs");
        righthand_rend = GameObject.Find("hands:Rhand").GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(invon_nextframe)
        {
            inventory.on = true;
            inventory.gameObject.SetActive(true);
            righthand.SetActive(false);
            rightray.SetActive(true);
            inventory.held_item = icopy;

            invon_nextframe = false;
        }
        bool grip_pressed    = grip.action.ReadValue<float>() != 0;
        bool trigger_pressed = trigger.action.ReadValue<float>() != 0;
        if(ignore_grip && !grip_pressed)
        {
            ignore_grip = false;
        }
        if (!ignore_grip && inventory.on && grip_pressed)
        {
            inventory.on = false;
            inventory.gameObject.SetActive(false);
            rightray.SetActive(false);
            righthand.SetActive(true);
            Debug.Log(inventory.held_item);
            if (inventory.held_item != null)
            {
                GameObject newobj = inventory.held_item.id switch
                {
                    1 =>
                        Instantiate(prefabs.transform.Find("Meat").gameObject, rightray.transform.position, rightray.transform.rotation),
                    2 =>
                        Instantiate(prefabs.transform.Find("Axe").gameObject, rightray.transform.position, rightray.transform.rotation),
                    3 =>
                        Instantiate(prefabs.transform.Find("Fang").gameObject, rightray.transform.position, rightray.transform.rotation),
                    4 =>
                        Instantiate(prefabs.transform.Find("Log").gameObject, rightray.transform.position, rightray.transform.rotation),
                    5 =>
                        Instantiate(prefabs.transform.Find("sword").gameObject, rightray.transform.position, rightray.transform.rotation),
                    6 =>
                        Instantiate(prefabs.transform.Find("tuatara").gameObject, rightray.transform.position, rightray.transform.rotation)
                };
                newobj.SetActive(true);
                Destroy(inventory.held_item);
                inventory.held_item = null;
            }
            
        }
        else if(!inventory.on && trigger_pressed)
        {
            if(grip_pressed)
            {
                ignore_grip = true;
            }

            Debug.Log("HOLDING ::: " + righthand_item + " OF :::" + (righthand_item != null ? righthand_item.gameObject : null));
            invon_nextframe = true;
            if (righthand_item != null)
            {
                icopy = Instantiate(righthand_item);
                icopy.gameObject.SetActive(false);
                Destroy(righthand_item.gameObject);
            }

        }
    }
}
