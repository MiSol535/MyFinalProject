using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunBehavior : StateMachineBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Transform player;
    float attackRange = 3;
    float runRange = 10;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.speed = 7;

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);

        if (distance < attackRange)
        {
            animator.SetBool("IsAttack", true);
        }

        if (distance > runRange)
        {
            animator.SetBool("IsRunning", false);
        }   
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        agent.speed = 4;
    }
}
