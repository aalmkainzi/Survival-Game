using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Bandit2 : StateMachineBehaviour
{
    Transform player;
    private Enemy die;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        die = animator.gameObject.GetComponent<Enemy>();

    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(player);
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance > 7f)
        {
            animator.SetBool("isAttacking2", false);
        }
        

        if (die.eHealth <= 0)
        {
            Debug.Log("Die_attack");
            animator.SetBool("isDie", true);
        }

    }


}