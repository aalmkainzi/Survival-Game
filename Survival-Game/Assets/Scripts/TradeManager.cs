using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trade_panel;
    public Trade_Want_Slot want_slot;
    public Trade_Give_Slot give_slot;
    public Button trade_button;
    public inventory inventory;
    public Trade current_trade;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void put_item_in_want(Item item)
    {
        if(item.icon_id == want_slot.item.icon_id)
        {
            want_slot.item = item;
            Image im = want_slot.transform.Find("Image").GetComponent<Image>();
            Material mat = im.material;

            Color temp = mat.color;
            temp.a = 1;
            mat.color = temp;
            
            inventory.set_held_item(null);
            trade_button.enabled = true;
        }
    }

    public void start_trade(Trade trade)
    {
        current_trade = trade;
        inventory.on = true;
        inventory.gameObject.SetActive(true);
        trade_panel.gameObject.SetActive(true);

        want_slot.set_item(trade.want);
        give_slot.set_item(trade.give);

        give_slot.GetComponent<Button>().enabled = false;
        want_slot.GetComponent<Button>().enabled = true;

        trade_button.enabled = false;
    }

    // when trade_give button clicked after Trade button ->
    public void complete_trade()
    {
        trade_panel.gameObject.SetActive(false);
    }

    public void trade_clicked()
    {
        give_slot.GetComponent<Button>().enabled = true;
        want_slot.GetComponent<Button>().enabled = false;
        Color tempc = give_slot.img.material.color;
        tempc.a = 1.0f;
        give_slot.img.material.color = tempc;

        Color tempc2 = want_slot.img.material.color;
        tempc2.a = 0.5f;
        want_slot.img.material.color = tempc2;

        trade_button.enabled = false;
    }

    public void give_clicked()
    {
        if (inventory.held_item == null)
        {
            inventory.set_held_item(give_slot.item);
            give_slot.GetComponent<Button>().enabled = false;
            trade_panel.SetActive(false);
            end_trade();
        }
    }
    
    public void want_clicked()
    {
        if (inventory.held_item != null)
        {
            put_item_in_want(inventory.held_item);
        }
    }

    public void end_trade()
    {
        if(trade_button.enabled || give_slot.GetComponent<Button>().enabled) 
        {
            inventory.set_held_item(want_slot.item);
        }

        trade_panel.gameObject.SetActive(false);

        want_slot.item = (null);
        give_slot.item = (null);

        current_trade.trade_active = false;
        current_trade = null;
    }
}
