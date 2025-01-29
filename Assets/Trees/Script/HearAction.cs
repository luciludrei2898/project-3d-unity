using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearAction : Action
{

    public float radius = 10f;
    public override bool Check(GameObject owner)
    {
        // VAMOS A LANZAR UNA ESFERA AL REDEDOR DEL DUEÑO DE LA ACCION

        // Castear esfera alrededor del dueño
        // Array de todos los colliders dentro de la esfera que hemos casteado

        Collider[] hits = Physics.OverlapSphere(owner.transform.position, radius);

        foreach (Collider hit in hits) { 
         if (hit.GetComponent<PlayerMovement>())
            {
                // estoy escuchando al jugador
                // devuelve un true y corta el foreach

                return true;
            }
        }

        return false; // si no lo encuentra, devuelve un false

        // LUEGO RECORREMOS TODO LO QUE ESTE DENTRO EN BUSCA DEL JUGADOR

    }
}
