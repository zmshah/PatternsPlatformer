//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract enemy class. Has a clone method for the prototype pattern and an enemy object method for getting and setting enemies
public abstract class Enemy 
{
    public abstract Enemy Clone(Vector3 position);

    public abstract GameObject EnemyObject
    {
        get;
        set;
    }
}
