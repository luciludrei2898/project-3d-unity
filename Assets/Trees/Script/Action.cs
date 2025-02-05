using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : ScriptableObject
{
    
    public abstract bool Check(GameObject owner); // METODO PARA COMPROBAR EL VALOR DE VALUE
}
