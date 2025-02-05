using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "GuardState (S)", menuName = "ScriptableObjects/States/GuardState")]

public class GuardState : State
{
    // Donde montamos guardia

    public Vector3 guardPoint;

    // Algoritmo a estrella A*
    // busqueda de rutas, como se llega mejor de un lugar a otro, etc
    public override State Run(GameObject owner)

        // Comportamiento para ir al punto de guardia 
    {
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(guardPoint);


        return base.Run(owner);
    }
}
