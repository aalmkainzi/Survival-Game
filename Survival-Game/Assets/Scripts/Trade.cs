using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trade : MonoBehaviour
{
    // Start is called before the first frame update

    public Item want;
    public Item give;
    public Transform player;
    public TradeManager trade_manager;
    public bool trade_active = false;
    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Vector3.Distance(player.position, transform.position) < 5) 
        {
            Debug.Log("REACHED");
            if (!trade_active)
            {
                trade_manager.start_trade(this);
                trade_active = true;
            }
            else
            {
                trade_manager.end_trade();
                trade_active = false;
            }
        }
    }
}
