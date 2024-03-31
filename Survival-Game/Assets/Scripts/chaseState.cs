using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class chaseState : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;
    private Enemy die;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
/*        Debug.Log("A");
*/        agent = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 3.5f;
       die = animator.gameObject.GetComponent<Enemy>();
    }


    

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
/*        Debug.Log("B");
*/        float distance = Vector3.Distance(player.position, animator.transform.position);
        agent.SetDestination(player.position);
        if (distance > 30f) 
        {
/*            Debug.Log("done");
*/            animator.SetBool("isChasing", false);
        }

        if (distance < 5f)
        {
/*            Debug.Log("done");
*/            animator.SetBool("isAttacking", true);
        }

        if(die.eHealth <= 0)
        {
            animator.SetBool("isDie", true);
        }


       
    }
   /* public void die_check(bool health, Animator animator)
    {
        
           animator.SetBool("isDie", true);
        
    }*/

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(animator.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
