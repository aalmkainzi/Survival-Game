using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public bool on;
    public Item held_item;
    public IconManager icon_manager;
    public Cursor_Follow cursor_Follow;
    // public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        Transform items = transform.Find("Items");

        foreach (Transform child in items)
        {
            GameObject child_obj = child.gameObject;
            Button btn = child_obj.GetComponent<Button>();
            btn.onClick.AddListener(delegate { slot_click(child_obj); });
        }

        on = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void slot_click(GameObject btn)
    {
        InventorySlot slot = btn.GetComponent<InventorySlot>();
        if (held_item != null)
        {
            if (slot.item != null)
            {
                Item temp = slot.item;
                slot.set_item(held_item);
                set_held_item(temp);
            }
            else
            {
                slot.set_item(held_item);
                set_held_item(null);
            }
        }
        else if(slot.item != null)
        {
            set_held_item(slot.item);
            slot.unset_icon();
        }
    }

    public void set_held_item(Item item)
    {
        if (item == null)
        {
            cursor_Follow.unset_icon();
        }
        else
        {
            cursor_Follow.set_icon(icon_manager.get_icon(item.icon_id));
        }
        held_item = item;
    }
}
