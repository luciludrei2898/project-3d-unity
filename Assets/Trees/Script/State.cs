using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{

    public State nextState;
    public Action action; 

    // TODOS TIENEN UN METODO RUN Y DEVUELVE UN ESTADO


    private bool CheckAction(GameObject owner)
    {
        return action.Check(owner) == action.value; // te devuelve si la accion se ha cumplido o no
    }

    // El virtual permite hacer override a las clases hijas e implementarlo
    public virtual State Run(GameObject owner)
    {
        if (CheckAction(owner))
        {
            return nextState;
        }
        return this; // This el estado actual
    }
   

}
