using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ItemGrab : XRGrabInteractable
{
    public player_input player_input;

    private void Start()
    {
        if(player_input == null)
        {
            player_input = GameObject.Find("InputManager").GetComponent<player_input>();
        }
    }

    // Start is called before the first frame update
    protected override void OnSelectEntering(SelectEnterEventArgs interactor)
    {
        trackRotation = false;
        base.OnSelectEntering(interactor);
        trackRotation = true;

        player_input.righthand_item = interactor.interactable.gameObject.GetComponent<Item>();
    }

    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        base.OnSelectExiting(args);

        player_input.righthand_item = null;
    }
}
