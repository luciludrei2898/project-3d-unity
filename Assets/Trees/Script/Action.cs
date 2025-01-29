using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action 
{
    
    public bool value; // VARIABLE QUE EVALUA SI ESTA ESCUCHANDO, SI ESTA CERCA, SI ES DE DIA, SI ES DE NOCHE

    public abstract bool Check(GameObject owner); // METODO PARA COMPROBAR EL VALOR DE VALUE
}
