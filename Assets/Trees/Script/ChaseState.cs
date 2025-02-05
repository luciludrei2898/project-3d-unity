using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName ="ChaseState (S)", menuName ="ScriptableObjects/States/ChaseState")]

public class ChaseState : State
{
    public override State Run(GameObject owner)
    {

        // 1 - Coger ubicacion del player 

        GameObject player  = FindObjectOfType<PlayerMovement>().gameObject;

        Vector3 playerPosition = player.transform.position;

        // 2 - Ir a playerPosition

        NavMeshAgent navCompoment = owner.GetComponent<NavMeshAgent>();
        navCompoment.SetDestination(playerPosition);

        // Base es el metodo del padre
        return base.Run(owner);
    }
}
