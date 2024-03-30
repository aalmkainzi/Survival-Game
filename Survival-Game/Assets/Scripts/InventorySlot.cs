using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventorySlot : MonoBehaviour
{
    public Item item;
    public IconManager icon_man;
    // Start is called before the first frame update
    void Start()
    {
        icon_man = gameObject.transform.parent.parent.GetComponent<inventory>().icon_manager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void set_item(Item item)
    {
        this.item = item;
        Image img = gameObject.transform.Find("Image").gameObject.GetComponent<Image>();
        img.sprite = icon_man.get_icon(item.icon_id).sprite;
        img.enabled = true;
    }

    public void unset_icon()
    {
        item = null;
        gameObject.transform.Find("Image").gameObject.GetComponent<Image>().enabled = false;
    }
}
