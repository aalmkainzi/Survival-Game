using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trade_Give_Slot : MonoBehaviour
{
    public Item item;
    public IconManager icon_man;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void set_item(Item item)
    {
        this.item = item;
        img.sprite = icon_man.get_icon(item.icon_id).sprite;
        img.enabled = true;
        img.material = new Material(img.material);
        Color tempc = img.material.color;
        tempc.a = 0.5f;
        img.material.color = tempc;

        GetComponent<Button>().enabled = false;
    }

    public void unset_icon()
    {
        item = null;
        gameObject.transform.Find("Image").gameObject.GetComponent<Image>().enabled = false;
    }
}
