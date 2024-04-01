using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ItemGrab : XRGrabInteractable
{
    // Start is called before the first frame update
    protected override void OnSelectEntering(SelectEnterEventArgs interactor)
    {
        trackRotation = false;
        base.OnSelectEntering(interactor);
        trackRotation = true;
    }
}
