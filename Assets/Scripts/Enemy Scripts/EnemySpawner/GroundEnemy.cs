//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ground enemy gameobject
public class GroundEnemy : Enemy
{
    //The default ground enemy. This is the first enemy created and is used as the basis for the other ground enemies.
    //The only thing changed between enemies is their positons
    private GameObject defaultGroundEnemy;

    private GameObject groundEnemy;

    private int count = 0;

    //Default constructor
    public GroundEnemy() { }

    //Ground enemy constructor to create a ground enemy. 
    public GroundEnemy(GameObject defaultGroundEnemy, Vector3 position)
    {
        count++;

        //Without this line i get error "the object you want to instantiate is null"
        //Possible reason -- defaultGroundEnemy is stored into prefab, when calling clone I'm calling the defaultGroundEnemy that I stored last time
        this.defaultGroundEnemy = defaultGroundEnemy;

        //This creates the enemy by instantiating it and assigning it to the current enemy object
        groundEnemy = GameObject.Instantiate(defaultGroundEnemy, position, Quaternion.identity);

        //The builder classes to build the enemy piece by piece
        EnemyBuilder builder = new GroundEnemyBuilder(groundEnemy);

        EnemyDirector director = new EnemyDirector();

        director.ConstructEnemy(builder);
    }

    //Get and set methods for the current ground enemy
    public override GameObject EnemyObject
    {
        get { return this.groundEnemy; }
        set { groundEnemy = value; }
    }

    //Clone method to return clone of ground enemy. The new monster is identical to the original in class and state
    public override Enemy Clone(Vector3 position)
    {
        return new GroundEnemy(defaultGroundEnemy, position); 
    }
}
