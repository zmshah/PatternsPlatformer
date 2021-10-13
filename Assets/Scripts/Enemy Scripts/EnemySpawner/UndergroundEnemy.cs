//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Underground enemy gameobject
public class UndergroundEnemy : Enemy
{
    //The default ground enemy. This is the first enemy created and is used as the basis for the other ground enemies.
    //The only thing changed between enemies is their positons
    private GameObject defaultUndergroundEnemy;

    private GameObject undergroundEnemy;

    private int count = 0;

    //Underground enemy constructor to create a Underground enemy.
    public UndergroundEnemy(GameObject defaultUndergroundEnemy, Vector3 position)
    {
        count++;

        this.defaultUndergroundEnemy = defaultUndergroundEnemy;

        //This creates the enemy by instantiating it and assigning it to the current enemy object
        undergroundEnemy = GameObject.Instantiate(defaultUndergroundEnemy, position, Quaternion.identity);

        //Enemy builder
        EnemyBuilder builder = new UndergroundEnemyBuilder(undergroundEnemy);

        EnemyDirector director = new EnemyDirector();

        director.ConstructEnemy(builder);
    }

    //Get and set methods for the current ground enemy
    public override GameObject EnemyObject
    {
        get { return this.undergroundEnemy; }
        set { undergroundEnemy = value; }
    }

    //Clone method to return clone of Underground enemy. The new monster is identical to the original in class and state
    public override Enemy Clone(Vector3 position)
    {
        return new UndergroundEnemy(defaultUndergroundEnemy, position);
    }
}
