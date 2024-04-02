using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieState : StateMachineBehaviour
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        BoxCollider[] bcs = animator.gameObject.GetComponents<BoxCollider>();

        foreach(BoxCollider bc in bcs)
        {
            bc.enabled = false;
        }

        Debug.Log("LEN " + bcs.Length);
    }

}
