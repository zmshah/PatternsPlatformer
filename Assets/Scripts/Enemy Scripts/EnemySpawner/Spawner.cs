//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context spawner class
public class Spawner 
{
    //Create an enemy prototype
    private Enemy prototype;

    public Spawner(Enemy prototype)
    {
        this.prototype = prototype;
    }

    //Spawn enemy. The class takes the enemies position as this needs to be varied
    public Enemy SpawnEnemy(Vector3 position)
    {
        return prototype.Clone(position);
    }
}
