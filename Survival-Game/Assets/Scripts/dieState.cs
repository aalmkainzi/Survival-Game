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

        animator.gameObject.GetComponent<AudioSource>().enabled=false;

    }


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bool b = AnimatorIsPlaying(stateInfo);
        
        if(!b)
        {
            Transform t = animator.gameObject.transform;
            bool found = false;
            foreach (Transform child in t)
            {
                if (!found && child.gameObject.name == "Loot")
                {
                    found = true;
                    child.gameObject.SetActive(true);
                }
                else
                {
                    child.gameObject.SetActive(false);
                }
            }
        }
    }

    bool AnimatorIsPlaying(AnimatorStateInfo stateInfo)
    {
        return stateInfo.normalizedTime < 1;
    }
}
