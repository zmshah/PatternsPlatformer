//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sky enemy gameobject
public class SkyEnemy : Enemy
{
    //The default sky enemy. This is the first enemy created and is used as the basis for the other ground enemies.
    //The only thing changed between enemies is their positons
    private GameObject defaultSkyEnemy;

    private GameObject skyEnemy;

    private int count = 0;

    //Sky enemy constructor to create a Sky enemy. 
    public SkyEnemy(GameObject defaultSkyEnemy, Vector3 position)
    {
        count++;

        this.defaultSkyEnemy = defaultSkyEnemy;

        //This creates the enemy by instantiating it and assigning it to the current enemy object
        skyEnemy = GameObject.Instantiate(defaultSkyEnemy, position, Quaternion.identity);

        //Enemy builder
        EnemyBuilder builder = new SkyEnemyBuilder(skyEnemy);

        EnemyDirector director = new EnemyDirector();

        director.ConstructEnemy(builder);
    }

    //Get and set methods for the current sky enemy
    public override GameObject EnemyObject
    {
        get { return this.skyEnemy; }
        set { skyEnemy = value; }
    }

    //Clone method to return clone of Sky enemy. The new monster is identical to the original in class and state
    public override Enemy Clone(Vector3 position)
    {
        return new SkyEnemy(defaultSkyEnemy, position);
    }
}
