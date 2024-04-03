using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animalChase : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        /*        Debug.Log("A");
        */
        agent = animator.GetComponent<NavMeshAgent>();
        agent.enabled = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 15f;

    }




    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        /*        Debug.Log("B");
        */
        float distance = Vector3.Distance(player.position, animator.gameObject.transform.position);
        if (distance <= 30f)
        {
            Vector3 Dir = animator.transform.position - player.position;

            agent.SetDestination(animator.transform.position + Dir);
        }
        else
        {
            animator.SetBool("isChasing", false);
        }







    }
}